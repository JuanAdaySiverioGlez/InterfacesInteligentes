using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastExercise : MonoBehaviour
{
    private GameObject[] esferasTipo2;

    private void Awake()
    {
        // Obtengo todas las esferas de cada tipo
        esferasTipo2 = GameObject.FindGameObjectsWithTag("SecondSphereGroup");
    }

    (GameObject, GameObject) FindNearestAndFarest() 
    {
        GameObject esferaMasCercana = null;
        float distanciaMinima = Mathf.Infinity;

        GameObject esferaMasLejana = null;
        float distanciaMaxima = -Mathf.Infinity;

        // Buscar la esfera de tipo 2 más cercana y más lejana al cubo
        foreach (GameObject esfera in esferasTipo2)
        {
            float distancia = Vector3.Distance(gameObject.transform.position, esfera.transform.position);

            if (distancia < distanciaMinima)
            {
                distanciaMinima = distancia;
                esferaMasCercana = esfera;
            }

            if (distancia > distanciaMaxima)
            {
                distanciaMaxima = distancia;
                esferaMasLejana = esfera;
            }
        }
        return (esferaMasCercana, esferaMasLejana);
    }


    IEnumerator MoveSphereHigh()
    {
        CanMoveSphere = false;
        yield return new WaitForSeconds(1f); // cada segundos subirá la esfera más cercana al cubo
        CanMoveSphere = true;
    }

    bool CanMoveSphere = true;
    void Update()
    {
        (GameObject masCercana, GameObject masLejana) = FindNearestAndFarest();

        // Aumentar la altura de la esfera de tipo 2 más cercana al cubo
        if (masCercana != null && CanMoveSphere)
        {
            StartCoroutine(MoveSphereHigh());
            Vector3 nuevaPosicion = masCercana.transform.position;
            nuevaPosicion.y += 1f; // Incrementa la altura
            masCercana.transform.position = nuevaPosicion;
        }

        // Cambiar el color de la esfera más lejana al presionar la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space) && masLejana != null)
        {
            Renderer renderer = masLejana.GetComponent<Renderer>();
            renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}

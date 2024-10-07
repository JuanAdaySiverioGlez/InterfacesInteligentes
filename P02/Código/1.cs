using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Vector3 colorVector;
    private Renderer objectRenderer;

    [SerializeField] private int framesToWait = 120;
    private int frameCounter;

    // En caso que el objeto desde el inspector se seleccione a Disable ChangeColor 
    // singificará que no estará cambiando constantemente 
    public bool DisabledChangeColor = false;

    void Start()
    {
        colorVector = new Vector3(Random.value, Random.value, Random.value);

        objectRenderer = GetComponent<Renderer>();

        if (!DisabledChangeColor)
        {
            UpdateObjectColor();
        }
    }

    void Update()
    {
        if (!DisabledChangeColor)
        {
            frameCounter++; // Incrementamos cada vez que se ejecuta el update un frame más

            if (frameCounter >= framesToWait)
            {
                ChangeRandomColorComponent();
                frameCounter = 0; // Reiniciar el contador de frames
            }
        }
    }

    // Que se note que es un método publico porque se utilizará en otro código
    // Cambia un componente aleatorio del vector de color
    public void ChangeRandomColorComponent()
    {
        int randomIndex = Random.Range(0, 3);
        colorVector[randomIndex] = Random.value;
        UpdateObjectColor();
    }

    private void UpdateObjectColor() // Actualiza el color usando el vector
    {
        Color newColor = new Color(colorVector.x, colorVector.y, colorVector.z);
        objectRenderer.material.color = newColor;
    }
}

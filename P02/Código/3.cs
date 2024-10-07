using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalizarInfoVector : MonoBehaviour
{
    // Dos variables Vector3 públicas para asignar valores desde el Inspector
    [Header("Variables a modificar")]
    public Vector3 vectorA;
    public Vector3 vectorB;


    [Header("Resultados en inspector")]
    // Variables para mostrar en el Inspector los resultados
    [SerializeField] private float magnitudeA;
    [SerializeField] private float magnitudeB;
    [SerializeField] private float angleBetween;
    [SerializeField] private float distanceBetween;
    [SerializeField] private string higherAltitudeMessage;

    void MagnitudeVectors()
    {
        // Magnitud de cada vector
        magnitudeA = vectorA.magnitude;
        magnitudeB = vectorB.magnitude;
        Debug.Log("Magnitud del vector A: " + magnitudeA);
        Debug.Log("Magnitud del vector B: " + magnitudeB);
    }

    void AnguloVectors()
    {
        // Ángulo entre ambos vectores
        angleBetween = Vector3.Angle(vectorA, vectorB);
        Debug.Log("Ángulo entre los vectores A y B: " + angleBetween + " grados");
    }

    void DistanceBetweenVectors()
    {
        // Distancia entre ambos vectores
        distanceBetween = Vector3.Distance(vectorA, vectorB);
        Debug.Log("Distancia entre los vectores A y B: " + distanceBetween);
    }

    void CompareVectorsAltitude()
    {
        // Comparar cuál vector está a mayor altura (componente y)
        if (vectorA.y > vectorB.y)
        {
            higherAltitudeMessage = "El vector A está a una mayor altura que el vector B.";
        }
        else if (vectorB.y > vectorA.y)
        {
            higherAltitudeMessage = "El vector B está a una mayor altura que el vector A.";
        }
        else
        {
            higherAltitudeMessage = "Ambos vectores están a la misma altura.";
        }
        Debug.Log(higherAltitudeMessage);
    }

    void Start()
    {
        MagnitudeVectors();
        AnguloVectors();
        DistanceBetweenVectors();
        CompareVectorsAltitude();
    }
}

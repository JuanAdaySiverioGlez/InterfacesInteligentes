using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    // Vector de desplazamiento configurado desde el Inspector
    public Vector3 desplazamiento;

    // Posición original del objeto
    private Vector3 posicionOriginal;

    void Start()
    {
        // Almacenar la posición original del objeto
        posicionOriginal = transform.position;
    }

    void Update()
    {
        // Si se pulsa la barra espaciadora
        if (Input.GetAxis("Jump") > 0)
        {
            // Mover el objeto a la nueva posición (posición original + desplazamiento)
            transform.position = posicionOriginal + desplazamiento;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeWhenButton : MonoBehaviour
{
    // Renderer del objeto para acceder al material y cambiar su color
    private Renderer objectRenderer;
    [Header("Cuando pulse la C")]
    [SerializeField] ChangeColor ChangeWhenUse_C_Key;
    [Header("Cuando pulse la Flecha hacia arriba")]
    [SerializeField] ChangeColor ChangeWhenUse_UpArrow_Key;

    void Update()
    {
        // Cambiar el color del cilindro cuando el usuario pulse la tecla 'C'
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeWhenUse_C_Key.ChangeRandomColorComponent();
        }

        // Cambiar el color del cubo cuando el usuario pulse la flecha 'Arriba'
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangeWhenUse_UpArrow_Key.ChangeRandomColorComponent();
        }
    }
}

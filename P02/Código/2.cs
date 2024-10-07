using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprimirFigurasMuestra : MonoBehaviour
{
    GameObject[] figurasMuestra;

    private void Awake()
    {
        figurasMuestra = GameObject.FindGameObjectsWithTag("FigurasMuestra");
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in figurasMuestra)
        {
            Debug.Log("Figura muestra -> " + obj.name);
        }
    }
}

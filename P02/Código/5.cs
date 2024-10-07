using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceBetweenOther : MonoBehaviour
{
    [SerializeField] GameObject[] objectsToCalculateDistance;

    private void Start()
    {
        foreach (GameObject obj in objectsToCalculateDistance)
        {
            Debug.Log(gameObject.name + " - " + obj.name + ": " + Vector3.Distance(obj.transform.position, gameObject.transform.position));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMyPositionVector : MonoBehaviour
{
    Transform ownTransform;

    private void Awake()
    {
        ownTransform = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ownTransform.position);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscribirNombreObjetos : MonoBehaviour
{
  // Start is called before the first frame update
  void Start() {
    ShowNameAndPositionOfAllObjects();
  }

  // Este método se encarga de Buscar todos los objetos que hayan que sean 
  // Del tipo GameObject, es decir, es una forma de encontrar todos los objetos
  // De la escena sin necesidad de asociar todos los objetos uno a uno.
  private void ShowNameAndPositionOfAllObjects() {
    GameObject[] todosLosObjetos = Object.FindObjectsOfType<GameObject>();
    PrintObjectsInfo(todosLosObjetos);
  }
  
  // Este método se encarga de imprimir el nombre y la posicion de cada objeto
  private void PrintObjectsInfo(GameObject[] objects) {
    foreach (GameObject obj in objects)
    {
      Debug.Log("  " + obj.name + ": " + obj.transform.position + " (position)");
    }
  }
}

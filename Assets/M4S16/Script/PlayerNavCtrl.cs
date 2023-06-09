
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavCtrl : MonoBehaviour
{
  RaycastHit raycastHit;
  private NavMeshAgent agente;

  // Start is called before the first frame update
  void Start()
  {
    agente = gameObject.GetComponent<NavMeshAgent>();
  }

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit hit;

      if (Physics.Raycast(ray, out hit))
      {
        agente.SetDestination(hit.point);
      }
    }
  }
}

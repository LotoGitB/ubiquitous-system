
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavCtrl : MonoBehaviour
{
  RaycastHit raycastHit;
  private NavMeshAgent agente;
  private Vector3 initialPos;

  // Start is called before the first frame update
  void Start()
  {
    initialPos = gameObject.transform.position;
    agente = gameObject.GetComponent<NavMeshAgent>();
    GameManager.gameManager.FindUIElements();
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

  public void RestartPosition()
  {
    gameObject.transform.position = initialPos;
    agente.SetDestination(gameObject.transform.position);
  }
}

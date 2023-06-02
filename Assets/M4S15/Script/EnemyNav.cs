using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
  RaycastHit raycastHit;
  //public GameObject cube;
  //public LayerMask layer;
  public Transform objetivo;
  private NavMeshAgent agente;
  // Start is called before the first frame update
  void Start()
  {
    agente = gameObject.GetComponent<NavMeshAgent>();
    agente.destination = objetivo.position;
  }

  // Update is called once per frame
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

  // private void FixedUpdate()
  // {
  //   if (
  //     //Crear una caja
  //     Physics.BoxCast(
  //       //Donde inicia la proyección (Cast) de la caja
  //       gameObject.transform.position,
  //       //El tamaño de la caja, (Vector3.one = (1,1,1))
  //       Vector3.one,
  //       //En que dirección vamos a mandar la proyección del cubo
  //       //Esta función identifica la dirección global para ir "Hacia el frente del personaje"
  //       //transform.TransformDirection(Vector3.forward),
  //       transform.forward,
  //       //Guarda toda la información del lugar donde colisiono la proyección
  //       out raycastHit,
  //       //Indica que nuestra proyección no tiene rotación
  //       Quaternion.identity,
  //       //El limite de la proyección, en este caso no tiene limite
  //       Mathf.Infinity,
  //       //La capa con la que puede detectar colisión.
  //       layer.value)
  //   )
  //   {
  //     cube.SetActive(true);
  //     cube.transform.position = raycastHit.point;
  //   }
  //   else
  //   {
  //     cube.SetActive(false);
  //   }
  // }
}

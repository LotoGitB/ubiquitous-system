using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
  public GameObject door;

  private void OnTriggerEnter(Collider other)
  {
    Debug.Log("Trigger");
    if (other.gameObject.CompareTag("Player"))
    {
      door.SetActive(false);
      gameObject.SetActive(false);
    }
  }
}

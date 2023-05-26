using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCtrl : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      other.gameObject.GetComponent<ReSpawnCtrl>().SetInitialPosition(gameObject.transform.position);
      gameObject.SetActive(false);
    }
  }
}

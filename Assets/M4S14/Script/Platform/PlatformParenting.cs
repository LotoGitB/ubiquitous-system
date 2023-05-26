using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformParenting : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      other.gameObject.transform.parent = gameObject.transform.parent.transform;
    }
  }

  private void OnTriggerExit(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      other.gameObject.transform.SetParent(null);
    }
  }
}

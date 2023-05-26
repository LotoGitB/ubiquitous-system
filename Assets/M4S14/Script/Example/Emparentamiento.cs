using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emparentamiento : MonoBehaviour
{
  public Transform padre;
  private bool isParented = false;

  private void Update()
  {
    if (Input.GetButtonDown("Jump"))
    {
      if (isParented)
      {
        transform.SetParent(null);
        isParented = false;
      }
      else
      {
        transform.SetParent(padre);
        isParented = true;
      }
    }
  }

}

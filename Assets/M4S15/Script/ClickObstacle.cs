using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObstacle : MonoBehaviour
{
  private void OnMouseDown()
  {
    gameObject.SetActive(false);
  }
}

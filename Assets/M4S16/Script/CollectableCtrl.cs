using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableCtrl : MonoBehaviour
{
  // public enum MyEnum
  // {
  //   Option1,
  //   Option2,
  //   Option3
  // }

  // [SerializeField]
  // public MyEnum dropdownValue;

  // public int cantidadDiamantes;
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      gameObject.SetActive(false);
      GameManager.gameManager.AgregarDiamante();
    }
  }
}

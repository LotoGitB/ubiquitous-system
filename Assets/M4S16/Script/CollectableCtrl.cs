using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableCtrl : MonoBehaviour
{
  public enum ColletableType
  {
    Diamante,
    VidaExtra,
    Enemigo,
    End
  }

  [SerializeField]
  public ColletableType dropdownValue;

  // public int cantidadDiamantes;
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      switch (dropdownValue)
      {
        case ColletableType.Diamante:
          GameManager.gameManager.AgregarDiamante();
          break;
        case ColletableType.VidaExtra:
          GameManager.gameManager.SetVidas(true);
          break;
        case ColletableType.Enemigo:
          GameManager.gameManager.SetVidas(false);
          break;
        case ColletableType.End:
          GameManager.gameManager.NextScene();
          break;
      }
      gameObject.SetActive(false);
    }
  }
}

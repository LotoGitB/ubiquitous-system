using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
  public static GameManager gameManager;
  public TextMeshProUGUI diamanteConteo;
  private int contadorDiamantes = 0;

  private void Awake()
  {
    if (gameManager == null)
    {
      gameManager = this;
    }
    else if (gameManager != this)
    {
      Destroy(gameObject);
    }
  }

  public void AgregarDiamante()
  {
    contadorDiamantes++;
    diamanteConteo.text = "Diamantes " + contadorDiamantes.ToString();
  }
}

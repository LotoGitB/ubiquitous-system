using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public static GameManager gameManager;
  private TextMeshProUGUI diamanteConteo;
  private TextMeshProUGUI vidasConteo;
  private TextMeshProUGUI nombreNivel;
  private GameObject playerRef;
  private int contadorDiamantes;
  public int contadorDiamantesAccess
  {
    get { return contadorDiamantes; }
    set
    {
      this.contadorDiamantes = value;
      diamanteConteo.text = "Diamantes: " + this.contadorDiamantes.ToString();
    }
  }
  private int vidas;
  public int contadorVidasAccess
  {
    get { return vidas; }
    set
    {
      this.vidas = value;
      vidasConteo.text = "Vidas: " + this.vidas.ToString();
    }
  }

  private void Awake()
  {
    if (gameManager != null && gameManager != this)
    {
      Destroy(this.gameObject);
    }
    else
    {
      gameManager = this;
      DontDestroyOnLoad(this.gameObject);
    }
  }

  private void Start()
  {
    this.contadorVidasAccess = 3;
  }

  public void FindUIElements()
  {
    diamanteConteo = GameObject.Find("UIDiamantesText").GetComponent<TextMeshProUGUI>();
    vidasConteo = GameObject.Find("UIVidasText").GetComponent<TextMeshProUGUI>();
    nombreNivel = GameObject.Find("UINivelText").GetComponent<TextMeshProUGUI>();
    playerRef = GameObject.FindGameObjectWithTag("Player");
    nombreNivel.text = SceneManager.GetActiveScene().name;
  }

  public void AgregarDiamante()
  {
    this.contadorDiamantesAccess++;
  }

  public void SetVidas(bool newLife)
  {
    if (newLife)
    {
      this.contadorVidasAccess++;
    }
    else
    {
      this.contadorVidasAccess--;
      playerRef.GetComponent<PlayerNavCtrl>().RestartPosition();
    }
    if (vidas == 0)
    {
      Debug.Log("Game over");
    }
  }

  public void NextScene()
  {
    int sceneIndex = SceneManager.GetActiveScene().buildIndex == 0 ? 1 : 0;
    SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Single);
  }
}

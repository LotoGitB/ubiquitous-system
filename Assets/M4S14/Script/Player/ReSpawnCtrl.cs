using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReSpawnCtrl : MonoBehaviour
{
  public TextMeshProUGUI lifeText;
  private int lifes = 3;
  private Vector3 initPosition;
  // Start is called before the first frame update
  void Start()
  {
    initPosition = gameObject.transform.position;
    lifeText.text = "Vidas: " + lifes.ToString();
  }


  public void SetInitialPosition(Vector3 newPos)
  {
    initPosition = newPos;
  }

  public void RestarPosition()
  {
    transform.position = initPosition;
    gameObject.GetComponent<PlayerMovementCtrl>().ClearPhysic();
    lifes--;
    lifeText.text = "Vidas: " + lifes.ToString();
    if (lifes == 0)
    {
      Debug.Log("GameOver");
      Debug.Break();
    }
  }
}

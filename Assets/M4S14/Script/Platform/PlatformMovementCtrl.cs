using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementCtrl : MonoBehaviour
{
  public bool isRight;
  public float directionMax;
  public float directionMin;
  private float speed;
  private bool toMax = true;
  private Vector3 direction;

  // Start is called before the first frame update
  void Start()
  {
    direction = isRight ? Vector3.right : Vector3.forward;
    speed = Random.Range(5, 15);
  }

  // Update is called once per frame
  void Update()
  {
    if (toMax)
    {
      gameObject.transform.Translate(direction * speed * Time.deltaTime);
      if ((isRight && gameObject.transform.position.x >= directionMax) ||
      (!isRight && gameObject.transform.position.z >= directionMax))
      {
        toMax = false;
      }
    }
    else
    {
      gameObject.transform.Translate((direction * -1) * speed * Time.deltaTime);
      if ((isRight && gameObject.transform.position.x <= directionMin) ||
      (!isRight && gameObject.transform.position.z <= directionMin))
      {
        toMax = true;
      }
    }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
  public float moveForce;
  public float jumpForce;
  private Rigidbody rb;
  private bool isGround = false;
  void Start()
  {
    rb = gameObject.GetComponent<Rigidbody>();
  }

  void Update()
  {
    rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveForce, rb.velocity.y, Input.GetAxis("Vertical") * moveForce);

    if (Input.GetButtonDown("Jump") && isGround)
    {
      rb.AddForce(new Vector3(rb.velocity.x, jumpForce, rb.velocity.z));
    }

    isGround = Physics.Raycast(transform.position, Vector3.down, 0.25f);
    Debug.DrawRay(transform.position, Vector3.down * 0.25f, Color.green);
  }

  // private void OnCollisionEnter(Collision collision)
  // {
  //   if (collision.gameObject.CompareTag("Ground"))
  //   {
  //     isGround = true;
  //     //transform.SetParent(collision.transform,true);
  //     Debug.Log("Grounded");
  //   }
  // }
}

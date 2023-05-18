using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovementCtrl : MonoBehaviour
{
  public float movementSpeed;
  public float rotationSpeed;
  public float jumpForce;
  private Animator animCtrl;
  private bool isGrounded;
  private Vector3 inputValue;
  private Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    animCtrl = gameObject.GetComponent<Animator>();
    rb = gameObject.GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
    {
      inputValue = new Vector3(0, 0, Input.GetAxis("Vertical")) * movementSpeed;
      animCtrl.SetBool("isMoving", true);
      if (Input.GetAxis("Horizontal") != 0)
      {
        gameObject.transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
      }
    }
    else
    {
      animCtrl.SetBool("isMoving", false);
    }

    if (Input.GetKey(KeyCode.LeftShift))
    {
      inputValue *= 3;
      animCtrl.SetBool("runButton", true);
    }
    else
    {
      animCtrl.SetBool("runButton", false);
    }

    isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);
    Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.green);
    animCtrl.SetFloat("yVelocity", rb.velocity.y);


    if (Input.GetButtonDown("Jump") && isGrounded)
    {
      rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

  }

  private void FixedUpdate()
  {
    Vector3 movement = transform.forward * inputValue.z * Time.deltaTime;
    rb.MovePosition(rb.position + movement);
    // rb.velocity
    //  = inputValue;

  }
}

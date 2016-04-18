using UnityEngine;
using System.Collections;
using System;

public class PlayerControls : MonoBehaviour
{
  ShapeBehaviour shapeBehaviour;
  new Rigidbody2D rigidbody;
  public float movementForce = 5;
  void Start()
  {
    shapeBehaviour = GetComponent<ShapeBehaviour>();
    rigidbody = GetComponent<Rigidbody2D>();
  }
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.A))
      shapeBehaviour.ActivateShape(0);
    if (Input.GetKeyDown(KeyCode.S))
      shapeBehaviour.ActivateShape(1);
    if (Input.GetKeyDown(KeyCode.D))
      shapeBehaviour.ActivateShape(2);

    var movement = (Input.GetKey(KeyCode.LeftArrow) ? 1.0f : 0) - (Input.GetKey(KeyCode.RightArrow) ? 1.0f : 0);
    var torque = movement * movementForce;
    rigidbody.AddTorque(torque, ForceMode2D.Impulse);
  }
}


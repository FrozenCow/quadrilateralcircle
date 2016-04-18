using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class LineShape : MonoBehaviour
{
  SpriteRenderer spriteRenderer;
  new PolygonCollider2D collider;
  new Rigidbody2D rigidbody;

  public Sprite sprite;

  void OnEnable()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
    rigidbody = GetComponent<Rigidbody2D>();
    collider = GetComponent<PolygonCollider2D>();

    spriteRenderer.sprite = sprite;
    collider.enabled = true;

    rigidbody.angularVelocity = 0;
    rigidbody.rotation = Mathf.Atan2(
      rigidbody.velocity.y,
      rigidbody.velocity.x
    ) * 180 / Mathf.PI;
  }

  void OnDisable()
  {
    spriteRenderer.sprite = null;
    collider.enabled = false;
  }

  void Update()
  {
    // Gliding
    var up = new Vector2(
      -Mathf.Sin(rigidbody.rotation * Mathf.PI / 180.0f),
      Mathf.Cos(rigidbody.rotation * Mathf.PI / 180.0f)
      );
    var upSpeed = Vector2.Dot(rigidbody.velocity, up) * rigidbody.mass;
    rigidbody.AddForce(up * -upSpeed, ForceMode2D.Impulse);
  }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class CircleShape : MonoBehaviour
{
  SpriteRenderer spriteRenderer;
  new CircleCollider2D collider;
  new Rigidbody2D rigidbody;

  public Sprite sprite;

  void OnEnable()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
    rigidbody = GetComponent<Rigidbody2D>();
    collider = GetComponent<CircleCollider2D>();

    spriteRenderer.sprite = sprite;
    collider.enabled = true;
  }

  void OnDisable()
  {
    spriteRenderer.sprite = null;
    collider.enabled = false;
  }
}
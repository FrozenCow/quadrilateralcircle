using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class SquareShape : MonoBehaviour
{
  SpriteRenderer spriteRenderer;
  new BoxCollider2D collider;
  new Rigidbody2D rigidbody;
  SurfaceBehaviour surfaceBehaviour;

  public Sprite sprite;

  void OnEnable()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
    rigidbody = GetComponent<Rigidbody2D>();
    collider = GetComponent<BoxCollider2D>();
    surfaceBehaviour = GetComponent<SurfaceBehaviour>();

    spriteRenderer.sprite = sprite;
    collider.enabled = true;

    Vector2 surfaceNormal;
    if (surfaceBehaviour.GetSurfaceNormal(out surfaceNormal))
    {
      print(UnityEngine.Random.value + "Surfaces: " + surfaceBehaviour.collisions.Count);
      var surfaceAngle = Mathf.Atan2(surfaceNormal.y, surfaceNormal.x);
      rigidbody.rotation = (surfaceAngle * 180) / Mathf.PI;
      rigidbody.AddForce(Vector2.up * Mathf.Abs(rigidbody.angularVelocity) * 12);
    }
    else
    {
      print("No surface");
    }
  }

  void OnDisable()
  {
    spriteRenderer.sprite = null;
    collider.enabled = false;
  }
}
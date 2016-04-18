using UnityEngine;
using System.Collections;

public class Breakable : MonoBehaviour {
  public float impactThreshold = 2.0f;
  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision == null || collision.rigidbody == null || collision.collider == null)
      return;
    if (collision.gameObject.GetComponent<PlayerControls>() == null)
      return;
    var force = collision.relativeVelocity.magnitude * collision.rigidbody.mass;
    print("Force: " + force);
    if (force > impactThreshold)
    {
      Destroy(gameObject);
    }
  }
}

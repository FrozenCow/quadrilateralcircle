using UnityEngine;
using System.Collections;
using Assets;

public class SmoothFollowBehaviour : MonoBehaviour {

    public GameObject following;
    public Vector2 velocity;
    public float velocityFactor = 0.5f;
    public float positionFactor = 0.01f;
    public float smoothing = 0.95f;
    public float damping = 0;
    void Start () {
	
	}
	
	void Update () {
        var followingVelocity = following.GetComponent<Rigidbody2D>().velocity - velocity;
        var difference = following.transform.position.ToVector2() - transform.position.ToVector2();
        var newVelocity = difference * positionFactor + followingVelocity * velocityFactor;
        velocity *= 1 - damping;
        velocity = velocity * smoothing + newVelocity * (1.0f - smoothing);
        transform.position += velocity.ToVector3();
    }
}

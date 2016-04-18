using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {
    public float Scale = 1;
	void Start () {
	
	}
	
	void Update () {
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(
            transform.position.x * Scale / transform.localScale.x,
            transform.position.y * Scale / transform.localScale.y
        );
	}
}

using UnityEngine;
using System.Collections;

public class Sign : MonoBehaviour {
  [Multiline]
  public string Text;

  SignUI signUI;
	// Use this for initialization
	void Start () {
    signUI = GameObject.FindGameObjectWithTag("SignUI").GetComponent<SignUI>();
  }
	
  void OnTriggerEnter2D(Collider2D collider)
  {
    signUI.SetText(Text);
    signUI.enabled = true;
  }

  void OnTriggerExit2D(Collider2D collider)
  {
    signUI.enabled = false;
  }

	// Update is called once per frame
	void Update () {
	  
	}
}

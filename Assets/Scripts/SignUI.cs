using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class SignUI: MonoBehaviour
{
  public Image image;
  public Text text;

  bool initialized = false;
  float targetPosition;
  float velocity = 0;

  void Initialize()
  {
    targetPosition = image.transform.position.y;
    initialized = true;
  }

  void OnEnable()
  {
    if (!initialized)
      Initialize();
    image.transform.position = new Vector3(
      image.transform.position.x,
      -image.preferredHeight * 0.5f,
      image.transform.position.z
    );
    image.enabled = true;
    text.enabled = true;
  }

  void OnDisable()
  {
    image.enabled = false;
    text.enabled = false;
  }

  void Update()
  {
    Vector3 position = image.transform.position;
    position.y = Mathf.SmoothDamp(position.y, targetPosition, ref velocity, 0.3f);
    image.transform.position = position;
  }

  public void SetText(string text)
  {
    this.text.text = text;
  }
}

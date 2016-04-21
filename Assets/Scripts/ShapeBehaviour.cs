using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using Assets;

public class ShapeBehaviour : MonoBehaviour {
  MonoBehaviour[] shapes;

  MonoBehaviour activeShape;

  public int activeShapes = 3;

  void Start()
  {
    shapes = new MonoBehaviour[] {
      gameObject.GetComponent<CircleShape>(),
      gameObject.GetComponent<SquareShape>(),
      gameObject.GetComponent<LineShape>()
    };
    ActivateShape(0);
  }

  public void ActivateShape(MonoBehaviour newShape)
  {
    //SendMessage("OnShapeshifting");
    if (activeShape != null)
      activeShape.enabled = false;
    activeShape = newShape;
    if (activeShape != null)
      activeShape.enabled = true;
    SendMessage("OnShapeshifted");
  }
  
  public void ActivateShape(int shapeIndex)
  {
    if (shapeIndex >= shapes.Length || shapeIndex >= activeShapes) return;
    ActivateShape(shapes[shapeIndex]);
  }
}

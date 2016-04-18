using UnityEngine;
using UnityEditor;
using System.Collections;

public class SnapToGrid : ScriptableObject
{

  [MenuItem("Window/Snap to Grid %g")]
  static void MenuSnapToGrid()
  {
    //var snapx = EditorPrefs.GetFloat("MoveSnapX");
    //var snapy = EditorPrefs.GetFloat("MoveSnapY");
    //var snapz = EditorPrefs.GetFloat("MoveSnapZ");
    var snapx = 1;
    var snapy = 1;
    var snapz = 1;
    foreach (Transform t in Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.OnlyUserModifiable))
    {
      t.position = new Vector3(
        Mathf.Round(t.position.x / snapx) * snapx,
        Mathf.Round(t.position.y / snapy) * snapy,
        Mathf.Round(t.position.z / snapz) * snapz
      );
    }
  }

}
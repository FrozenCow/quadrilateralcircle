using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {
  public string nextSceneName;

  void OnTriggerEnter2D(Collider2D collider)
  {
    SceneManager.LoadScene(nextSceneName);
  }
}

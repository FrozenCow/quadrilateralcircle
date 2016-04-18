using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Hotkeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown(KeyCode.R))
    {
      var sceneName = SceneManager.GetActiveScene().name;
      SceneManager.LoadScene(sceneName);
    }
    if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.P))
    {
      var index = SceneManager.GetActiveScene().buildIndex + 1;
      print(SceneManager.GetActiveScene().buildIndex);
      print(SceneManager.sceneCountInBuildSettings);
      SceneManager.LoadScene(index % SceneManager.sceneCountInBuildSettings);
    }
    if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.O))
    {
      var index = SceneManager.GetActiveScene().buildIndex - 1 + SceneManager.sceneCount;
      SceneManager.LoadScene(index % SceneManager.sceneCountInBuildSettings);
    }

  }
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void click()
    {
        SceneManager.LoadScene("level2");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void click()
    {
        SceneManager.LoadScene("level1");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

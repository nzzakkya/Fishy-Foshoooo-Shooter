using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void click()
    {
        SceneManager.LoadScene("mainmenu");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

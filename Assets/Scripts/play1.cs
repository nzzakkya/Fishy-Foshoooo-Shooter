using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class play1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public void click()
    {
        SceneManager.LoadScene("level1");
    }
	

}

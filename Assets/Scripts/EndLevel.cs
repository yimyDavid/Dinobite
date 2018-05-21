using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {
    public string scnEndLevel;
        
    void Start ()
    {
        HelperEndLevel.setCurrentLevel(SceneManager.GetActiveScene().name);
    }

   // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            
            HelperEndLevel.setNextLevel(SceneManager.GetActiveScene().name);
            Debug.Log(HelperEndLevel.nextLevel);
            SceneManager.LoadScene(scnEndLevel);

        }

        if (HelperEndLevel.isLastLevel())
        {
            Debug.Log("last");
            HelperEndLevel.hideNextButton = false;
        }
        else
        {
            HelperEndLevel.hideNextButton = true;
        }
    }
}

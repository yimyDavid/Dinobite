using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelController : MonoBehaviour {

    string LEVEL_SELECT_SCREEN = "LevelSelect";
    string REPEAT_LEVEL = "Level1";
    string NEXT_LEVEL = "Level2";
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PressHomeButton()
    {
        SceneManager.LoadScene(LEVEL_SELECT_SCREEN);
        Debug.Log(NEXT_LEVEL);
    }

    public void PressRepeatLevel()
    {
        SceneManager.LoadScene(REPEAT_LEVEL);
    }

    public void PressNextLevel()
    {
        SceneManager.LoadScene(NEXT_LEVEL);
    }
}

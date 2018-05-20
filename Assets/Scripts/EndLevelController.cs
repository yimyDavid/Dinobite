using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelController : MonoBehaviour {

    string LEVEL_SELECT_SCREEN = "LevelSelect";
    string REPEAT_LEVEL = HelperEndLevel.currentLevel;
    string NEXT_LEVEL = HelperEndLevel.nextLevel;

    GameObject nextButton;
    // Use this for initialization
    void Start () {
        nextButton = this.transform.Find("nextlevel").gameObject;
        
        nextButton.SetActive(HelperEndLevel.hideNextButton);
        Debug.Log(HelperEndLevel.hideNextButton);


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

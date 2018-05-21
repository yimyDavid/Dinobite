using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelperEndLevel {

    static public string currentLevel = "Level1";
    static public string nextLevel;

    public static int scoreLevel = 0;
    //static int numberOfLevelScenes = SceneManager.sceneCountInBuildSettings - 2;
    static int numberOfLevelScenes = 2;

    static public bool hideNextButton = true;
    public static int levelNumber;

    public static void setNextLevel(string levelName)
    {
        levelNumber = int.Parse(levelName[levelName.Length-1].ToString());
        nextLevel = "Level" + (levelNumber + 1).ToString();
    }

    public static void setCurrentLevel(string levelName)
    {
        currentLevel = levelName;
    }

    public static string getNextLevel()
    {
        return nextLevel;
    }

    public static bool isLastLevel()
    {
        /* check if the level is the last one to hide the next button*/
        return (levelNumber + 1) > numberOfLevelScenes;
    }
}

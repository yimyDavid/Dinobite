using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperEndLevel {

    static public string currentLevel = "Level1";
    static public string nextLevel;

    static public int scoreLevel = 0;

    public static void setNextLevel(string levelName)
    {
        int levelNumber = int.Parse(levelName[levelName.Length-1].ToString());
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
}

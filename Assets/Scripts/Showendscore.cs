using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Showendscore : MonoBehaviour {

    Text ScoreLevel;
	// Use this for initialization
	void Start () {
        ScoreLevel = GetComponent<Text>();
        
	}
	
	// Update is called once per frame
	void Update () {
        ScoreLevel.text = HelperEndLevel.scoreLevel + "";
    }
}

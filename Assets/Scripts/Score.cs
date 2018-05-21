﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    Text treats;
    private Player player;
    // Use this for initialization
    void Start () {
        treats = GetComponent<Text>();
        player = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update () {
        treats.text = "Treats: " + player.treats;
        HelperEndLevel.scoreLevel = player.treats;
	}
}

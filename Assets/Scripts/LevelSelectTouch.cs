﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectTouch : MonoBehaviour {

    private Selector selector;
	// Use this for initialization
	void Start () {
        selector = FindObjectOfType<Selector>();
	}
	
    public void PressLeftArrow()
    {
        selector.moveRight = false;
        selector.moveLeft = true;
    }

    public void PressRightArrow()
    {
        selector.moveRight = true;
        selector.moveLeft = false;
    }

    public void ReleaseLeftArrow()
    {
        selector.moveLeft = false;
    }

    public void ReleaseRightArrow()
    {
        selector.moveRight = false;
    }

    public void Select()
    {
        selector.selectLevel();
    }
	// Update is called once per frame
	void Update () {
		
	}
}

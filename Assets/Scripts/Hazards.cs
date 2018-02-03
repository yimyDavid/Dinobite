﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour {

    private Player player;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            player.transform.position = new Vector2(-12.45f, 5.69f);
        }
    }
}

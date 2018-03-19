using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {

    private Player player;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
	}
	
    public void pressLeftArrow()
    {
        player.moveRight = false;
        player.moveLeft = true;
    }

    public void pressRightArrow()
    {
        player.moveRight = true;
        player.moveLeft = false;
    }

    public void releaseLeftArrow()
    {
        player.moveLeft = false;
    }

    public void releaseRightArrow()
    {
        player.moveRight = false;
    }

    public void Jump()
    {
        player.jump();
    }
	// Update is called once per frame
	void Update () {
		
	}
}

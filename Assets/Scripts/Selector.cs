using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour {

    public bool moveLeft;
    public bool moveRight;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x > -3 && (moveLeft || Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            transform.position = new Vector2(transform.position.x - (float)4.93, transform.position.y);
            moveLeft = false;
        }
        else if(transform.position.x < (float)0.93 && (moveRight || Input.GetKeyDown(KeyCode.RightArrow)))
        {
            transform.position = new Vector2(transform.position.x + (float)4.93, transform.position.y);
            moveRight = false;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            selectLevel();
        }
	}

    public void selectLevel()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selector : MonoBehaviour {

    public bool moveLeft;
    public bool moveRight;
    private string levelchoice;
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
            //Debug.Log("test");
            selectLevel();
        }
	}

    public void selectLevel()
    {
        SceneManager.LoadScene(levelchoice);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.name);
        levelchoice = other.name;
    }
}

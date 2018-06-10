using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

    public int thisLevel;
    private Selector selector;
    // Use this for initialization
	void Start () {
        selector = FindObjectOfType<Selector>();
        
    }
	
	// Update is called once per frame
	void Update () {
        /* add 1 to the previous level to enable the next level,
         * otherwise this condition will neve be true*/
	   if(selector.farthestLevel + 1 < thisLevel)
        {
            this.tag = "off";
            GetComponent<Renderer>().enabled = false;
        }
        else
        {
            // Debug.Log("Should show");
            this.tag = "on";
            GetComponent<Renderer>().enabled = true;
        }
	}
}

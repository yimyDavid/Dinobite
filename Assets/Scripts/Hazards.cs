using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour {

    private Player player;
    public GameObject Blood;
    public AudioClip dieSound1;
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
            SoundManager.instance.RandomizeSfx(dieSound1);
            //StartCoroutine("respawndelay");
            player.dying();
        }
    }

}

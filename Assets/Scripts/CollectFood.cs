using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CollectFood : MonoBehaviour {
  
    public GameObject Bite;
    public Player player;
    public AudioSource biteSound;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
        biteSound = FindObjectOfType<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            biteSound.Play();
            player.treats++;
            Instantiate(Bite, this.transform.position, this.transform.rotation);
            Destroy(gameObject);
        }
    }
}

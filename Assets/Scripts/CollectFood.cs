using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CollectFood : MonoBehaviour {
  
    public GameObject Bite;
    public Player player;
    public AudioClip biteSound1;
    public AudioClip biteSound2;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //biteSound.Play();
            SoundManager.instance.RandomizeSfx(biteSound1, biteSound2);
            player.treats++;
            Instantiate(Bite, this.transform.position, this.transform.rotation);
            Destroy(gameObject);
        }
    }
}

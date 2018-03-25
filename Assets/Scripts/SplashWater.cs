using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashWater : MonoBehaviour {

    public AudioClip waterSplash1;
    public AudioClip waterSplash2;
	// Use this for initialization
	void Start () {
	
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "ThrownToWater")
        {
            SoundManager.instance.RandomizeSfx(waterSplash1, waterSplash2);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}

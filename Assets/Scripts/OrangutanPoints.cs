using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrangutanPoints : MonoBehaviour {

    public Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //biteSound.Play();
            //SoundManager.instance.RandomizeSfx(biteSound1, biteSound2);
            player.treats += 100;
            //Instantiate(Bite, this.transform.position, this.transform.rotation);
            Destroy(gameObject);
        }
    }
}

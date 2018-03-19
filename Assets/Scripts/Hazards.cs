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
            StartCoroutine("respawndelay");
        }
    }

    public IEnumerator respawndelay()
    {
        Instantiate(Blood, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1);
        player.transform.position = new Vector2(-12.45f, 4.69f);
        player.GetComponent<Renderer>().enabled = true;
        player.enabled = true;
    }
}

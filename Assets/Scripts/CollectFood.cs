using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFood : MonoBehaviour {
  
    public GameObject Bite;
    public Player player;
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
            player.treats++;
            Instantiate(Bite, this.transform.position, this.transform.rotation);
            Destroy(gameObject);
        }
    }
}

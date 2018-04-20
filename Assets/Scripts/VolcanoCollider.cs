using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolcanoCollider : MonoBehaviour {
   
    public float spawnTime = 4f;
    // Use this for initialization
    void Start () {
        if (gameObject.activeInHierarchy)
            gameObject.SetActive(true);

        StartCoroutine(LateCall());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator LateCall()
    {
        yield return new WaitForSeconds(spawnTime);
        gameObject.SetActive(false);
        Debug.Log("after 4 seconds");
    }
}

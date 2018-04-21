﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour {

    public GameObject volcanoEruption;
    public VolcanoCollider vc;
    public float spawnTime = 4f;
    public float spawnDuration = 3f;
   
	// Use this for initialization
	void Start () {
        
        InvokeRepeating("SpawnFire", spawnTime, spawnDuration);
        
        
	}
	
	// Update is called once per frame
	void Update () {
       // Instantiate(volcanoEruption, volcanoEruption.transform.position, volcanoEruption.transform.rotation);
       // SleepTimeout(5);
    }

    void SpawnFire()
    {
       Instantiate(volcanoEruption);        
    }
}

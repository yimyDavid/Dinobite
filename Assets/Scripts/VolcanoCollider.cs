using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolcanoCollider : MonoBehaviour {
   
    public float spawnTime = 7f;
    public float spawnDuration = 3f;
    public int counter = 0;
    public GameObject vc;
    // Use this for initialization
    void Start () {
        //InvokeRepeating("HideShowCollider", spawnTime, spawnDuration);
        StartCoroutine("HideUnhide");
    }
	
	// Update is called once per frame
	void Update () {
        //StartCoroutine("HideUnhide");
    }

    

    public IEnumerator HideUnhide()
    {
        while (true)
        {
            vc = this.transform.Find("volcanocollider").gameObject;
            yield return new WaitForSeconds(3);
            vc.SetActive(true);
            //vc = this.transform.Find("volcanocollider").gameObject;
            yield return new WaitForSeconds(2);
            vc.SetActive(false);
        }
    }

  

   //TODO: use parent gameobject

}

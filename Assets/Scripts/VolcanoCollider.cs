using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolcanoCollider : MonoBehaviour {
   
    public float spawnTime = 7f;
    public float spawnDuration = 3f;
    public int counter = 0;
    public GameObject eruption;
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
        vc = this.transform.Find("volcanocollider").gameObject;
        while (true)
        {
            
            yield return new WaitForSeconds(3f);
            vc.SetActive(true);
            Instantiate(eruption, eruption.transform.position, eruption.transform.rotation);
            //Debug.Log(this.transform.position);
            //vc = this.transform.Find("volcanocollider").gameObject;
            yield return new WaitForSeconds(0.5f);
            vc.SetActive(false);
        }
    }

  

   //TODO: use parent gameobject

}

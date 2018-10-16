using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGPlatformDestroyer : MonoBehaviour {

    public GameObject platformerDestructionPoint;

	// Use this for initialization
	void Start () {
        platformerDestructionPoint = GameObject.Find("PlatformDestructionPoint");
	}
	
	// Update is called once per frame
	void Update () {
		
        if(transform.position.x < platformerDestructionPoint.transform.position.x)
        {

            //Destroy(gameObject);
            gameObject.SetActive(false);

        }

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGGameManager : MonoBehaviour {

    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    private UnityEngine.Networking.PlayerController thePlayer;
    private Vector3 playerStartPoint;
	// Use this for initialization
	void Start () {
        platformStartPoint = platformGenerator.position;
        //playerStartPoint = thePlayer.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    /*public IEnumerator RestartGameCo()
    {

    }*/
}

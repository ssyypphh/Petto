using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGBackgroundScroll : MonoBehaviour {

    Material mat;
    Vector2 offset;

    public int xVelocity, yVelocity;
    public bool onAir = false;
    //private int counter=0;

    private void Awake()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Use this for initialization
    void Start () {

        //offset = new Vector2(xVelocity, yVelocity);
        
        
	}
	
	// Update is called once per frame
	void Update () {
        /*counter++;
        if (MGPlatformerPlayer.playerJumped == true)
        {
            Debug.Log("Background scroll is faster now");
            xVelocity = 4;
        }
        else
        {
            if(counter <= 59)
            {
                xVelocity = 2;
            }
            counter = 0;
        }*/
        offset = new Vector2(xVelocity, yVelocity);
        mat.mainTextureOffset += offset * Time.deltaTime;
	}
}

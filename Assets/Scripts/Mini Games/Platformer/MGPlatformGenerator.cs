using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGPlatformGenerator : MonoBehaviour {

    public GameObject thePlatform;
    public Transform generationPoint;

    private float platformWidth;
    private float[] platformWidths;

    public float distanceBetween;
    public float distanceBetweenMin, distanceBetweenMax;

    //public GameObject[] thePlatforms;
    private int platformSelector;

    public MGObjectPooler[] theObjectPools;

    private float minHeight, maxHeight;
    public Transform maxHeightPoint;
    public float maxHeightChange;
    private float heightChange;

	// Use this for initialization
	void Start () {
        //platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;

        platformWidths = new float[theObjectPools.Length];

        for(int i = 0; i < theObjectPools.Length; i++)
        {
            platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
        }

        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin,distanceBetweenMax);

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBetween, 
                heightChange, transform.position.z);

            platformSelector = Random.Range(0, theObjectPools.Length);

            heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange);

            #region Height constraints of generated platforms
            if (heightChange > maxHeight)
            {
                heightChange = maxHeight;
            }

            else if(heightChange < minHeight)
            {
                heightChange = minHeight;
            }
            #endregion
            //Instantiate(/*thePlatform,*/ thePlatforms[platformSelector], transform.position, transform.rotation);

            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2),
                transform.position.y, transform.position.z);
        }

	}
}

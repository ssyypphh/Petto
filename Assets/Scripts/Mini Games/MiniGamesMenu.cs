// Code Reviewed! (10-05-18)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MiniGamesMenu : MonoBehaviour {

    public Button buttonBack, buttonRockPaperScissors, buttonPlatformer, buttonDrawing;

	// Use this for initialization
	void Start () {
        setUpEvents();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void setUpEvents(){
        buttonBack.onClick.AddListener(() => SceneManager.LoadScene("Main Menu"));
        //buttonRockPaperScissors.onClick.AddListener(() => SceneManager.LoadScene(""));
        buttonPlatformer.onClick.AddListener(() => SceneManager.LoadScene("Platformer"));
        //buttonDrawing.onClick.AddListener(() => SceneManager.LoadScene(""));
    }
}

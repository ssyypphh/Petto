using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIPlatformer : MonoBehaviour {

    public Button buttonPause;
    public TextMeshProUGUI textScore;
    private double trueScore;

	// Use this for initialization
	void Start () {
        setUpEvents();
	}
	
	// Update is called once per frame
	void Update () {
        
        trueScore = MGPlatformerPlayer.scoreCounter / 30;
        textScore.SetText("Iskor: " + trueScore);

    }

    void setUpEvents()
    {
        buttonPause.onClick.AddListener(() => SceneManager.LoadScene("Mini Games Menu"));
    }
}

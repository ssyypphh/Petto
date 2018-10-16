using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class UIPetName : MonoBehaviour {

    public TMP_InputField textFieldPetName;
    public Button buttonOk;

	// Use this for initialization
	void Start () {
        setUpEvents();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void setUpEvents(){
        buttonOk.onClick.AddListener(() =>
        {
            if(textFieldPetName.text.Equals("")){
                return;
            }
            PlayerPrefs.SetString("DogName", textFieldPetName.text);
            PlayerPrefs.SetFloat("DogHealthiness", 10);
            PlayerPrefs.SetFloat("DogHappiness", 10);
            PlayerPrefs.SetFloat("DogSatiation", 10);
            PlayerPrefs.SetFloat("DogStress", 10);
            PlayerPrefs.SetFloat("DogEnergy", 10);

            PlayerPrefs.SetString("UserRegistered", "Y");
            SceneManager.LoadScene("Main Game");
        });
    }
}


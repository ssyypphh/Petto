using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIGenderSelection : MonoBehaviour {

    public Button buttonMale, buttonFemale, buttonChoose;

	// Use this for initialization
	void Start () {
        setUpEvents();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void setUpEvents(){
        buttonMale.onClick.AddListener(() =>
        {
            buttonMale.GetComponent<Image>().enabled = true;
            buttonFemale.GetComponent<Image>().enabled = false;

            PlayerPrefs.SetString("DogGender", "M");
        });
        buttonFemale.onClick.AddListener(() =>
        {
            buttonMale.GetComponent<Image>().enabled = false;
            buttonFemale.GetComponent<Image>().enabled = true;

            PlayerPrefs.SetString("DogGender", "F");
        });
        buttonChoose.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Pet Name");
        });
    }
}

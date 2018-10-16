using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIRecommendedBreed : MonoBehaviour {

    public Image imageBreed;
    public TextMeshProUGUI textBreed, buttonGoWithRecommendedBreedText;
    public Button buttonChooseAnotherBreed, buttonGoWithRecommendedBreed;

	// Use this for initialization
	void Start () {
        setUpEvents();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void setUpEvents(){
        buttonChooseAnotherBreed.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Breed Selection");
        });
        buttonGoWithRecommendedBreed.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Gender Selection");
        });
    }
}

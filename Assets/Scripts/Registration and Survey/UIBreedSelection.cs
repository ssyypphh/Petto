using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIBreedSelection : MonoBehaviour {

    public Button buttonNavigateLeft, buttonNavigateRight, buttonChoose;
    public TextMeshProUGUI textBreed;
    public Image imageBreed;

    int currentBreedSelected = 0;

	// Use this for initialization
	void Start () {
        setUpEvents();
        updateBreedUI(currentBreedSelected);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void updateBreedUI(int arrayListDogBreedIndex)
    {
        if(arrayListDogBreedIndex < 0)
        {
            return;
        }
        if(arrayListDogBreedIndex > DogList.arrayListDogBreed.Count - 1)
        {
            return;
        }
        Dog dog = (Dog) DogList.arrayListDogBreed[arrayListDogBreedIndex];
        textBreed.SetText(dog.Breed);
    }

    void setUpEvents(){
        buttonNavigateLeft.onClick.AddListener(() =>
        {
            if(currentBreedSelected <= 0)
            {
                return;
            }
            currentBreedSelected--;
            updateBreedUI(currentBreedSelected);
        });
        buttonNavigateRight.onClick.AddListener(() =>
        {
            if(currentBreedSelected >= DogList.arrayListDogBreed.Count - 1)
            {
                return;
            }
            currentBreedSelected++;
            updateBreedUI(currentBreedSelected);
        });
        buttonChoose.onClick.AddListener(() =>
        {
            switch (currentBreedSelected)
            {
                case 0:
                    PlayerPrefs.SetString("DogBreed", "P");
                    break;
                case 1:
                    PlayerPrefs.SetString("DogBreed", "G");
                    break;
                case 2:
                    PlayerPrefs.SetString("DogBreed", "B");
                    break;
            }
            SceneManager.LoadScene("Gender Selection");
        });
    }
}

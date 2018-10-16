/* Petto: An AI Driven Virtual Pet Mobile Game
 * 
 * Developed & Designed By: VITAN, Justine Paul S.
 *                          PEREZ, Jance Gionn M.
 *                          TALAMAYAN, John Albert P.
 * 
 * Last Updated: October 16, 2018
 */

/* ============================== */
#region Imports
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
#endregion
/* ============================== */

public class UIBreedSelection : MonoBehaviour {

    /* ============================== */
    #region Global Variables
    public Button buttonNavigateLeft, buttonNavigateRight, buttonChoose;
    public TextMeshProUGUI textBreed;
    public Image imageBreed;

    int currentBreedSelected = 0;
    #endregion
    /* ============================== */


    /* ============================== */
    #region Override Methods
	void Start () {
        setUpEvents();
        updateBreedUI(currentBreedSelected);
	}
	
	void Update () {
		
	}
    #endregion
    /* ============================== */


    /* ============================== */
    #region UI Methods
    void setUpEvents()
    {
        buttonNavigateLeft.onClick.AddListener(() =>
        {
            if (currentBreedSelected <= 0)
            {
                return;
            }
            currentBreedSelected--;
            updateBreedUI(currentBreedSelected);
        });
        buttonNavigateRight.onClick.AddListener(() =>
        {
            if (currentBreedSelected >= DogList.arrayListDogBreed.Count - 1)
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
    #endregion
    /* ============================== */

}

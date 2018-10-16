// Code Reviewed! (10-07-18)
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIMainGame : MonoBehaviour {

    public TextMeshProUGUI FPSText;

    public Button buttonPause, buttonInventory, buttonShop, UIPauseButtonResume, UIPauseButtonProfile, UIPauseButtonSettings, UIPauseButtonQuit;
    public GameObject UIPauseMenu;

    public GameObject gameObjectPoodle, gameObjectGermanShepherd, gameObjectBulldog;

	// Use this for initialization
	void Start () {
        setUpEvents();
        generateDogBreedModels();
    }
	
	// Update is called once per frame
	void Update () {
        updateFPSCounter();
	}

    void OnDestroy()
    {
        Utilities.updateLastMainGameExitTime();
    }

    void generateDogBreedModels()
    {
        if (Utilities.getDogBreed().Equals("P"))
        {
            gameObjectPoodle.active = true;
        }
        else if (Utilities.getDogBreed().Equals("G"))
        {
            gameObjectGermanShepherd.active = true;
        }
        else if (Utilities.getDogBreed().Equals("B"))
        {
            gameObjectBulldog.active = true;
        }
    }

    void updateFPSCounter(){
        FPSText.text = ((int)(1.0f / Time.smoothDeltaTime)) + " FPS";
    }

    void setUpEvents (){
        buttonPause.onClick.AddListener(() => {
            if (UIPauseMenu.active){
                UIPauseMenu.SetActive(false);
            }else{
                UIPauseMenu.SetActive(true);
            }
        });

        setUpEventsForUIPauseMenu();
    }

    void setUpEventsForUIPauseMenu (){
        UIPauseButtonResume.onClick.AddListener(() => { UIPauseMenu.SetActive(false); });
        UIPauseButtonProfile.onClick.AddListener(() => { });
        UIPauseButtonSettings.onClick.AddListener(() => { });
        UIPauseButtonQuit.onClick.AddListener(() => { SceneManager.LoadScene("Main Menu"); });
    }
}

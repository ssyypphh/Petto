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
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
#endregion
/* ============================== */

public class UIMainGame : MonoBehaviour
{

    /* ============================== */
    #region Global Variables
    public TextMeshProUGUI FPSText, CMHealthinessText, CMHappinessText, CMSatiationText, CMStressText, CMEnergyText;

    public Button buttonPause, buttonCameraMode, buttonConditionMeters, buttonInventory, buttonShop, UIPauseButtonResume, UIPauseButtonProfile, UIPauseButtonSettings, UIPauseButtonQuit;
    public GameObject UIPauseMenu, UIConditionMeters;

    public GameObject gameObjectPoodle, gameObjectGermanShepherd, gameObjectBulldog;

    public Camera[] cameraMode = new Camera[2];
    int currentCameraMode = 0;
    #endregion
    /* ============================== */


    /* ============================== */
    #region Override Methods
    void Start()
    {
        setUpEvents();
        generateDogBreedModels();
        //Utilities.updateConditionMetersWhenStartingMainGame(DateTime.Now, 2, 2, 2, 2, 2);
    }

    void Update()
    {
        updateFPSCounter();
        updateConditionMetersUI();
    }

    void OnDestroy()
    {
        Utilities.updateLastMainGameExitTime();
    }
    #endregion
    /* ============================== */


    /* ============================== */
    #region UI Methods
    void setUpEvents()
    {
        buttonPause.onClick.AddListener(() =>
        {
            if (UIPauseMenu.activeSelf)
            {
                UIPauseMenu.SetActive(false);
            }
            else
            {
                UIPauseMenu.SetActive(true);
            }
        });
        buttonCameraMode.onClick.AddListener(() =>
        {
            if (currentCameraMode >= cameraMode.Length - 1)
            {
                currentCameraMode = -1;
            }
            currentCameraMode++;
            disableAllCameraModesExceptFor(currentCameraMode);
        });
        buttonConditionMeters.onClick.AddListener(() =>
        {
            if (UIConditionMeters.activeSelf)
            {
                UIConditionMeters.SetActive(false);
            }
            else
            {
                UIConditionMeters.SetActive(true);
            }
        });

        setUpEventsForUIPauseMenu();
    }

    void setUpEventsForUIPauseMenu()
    {
        UIPauseButtonResume.onClick.AddListener(() => { UIPauseMenu.SetActive(false); });
        UIPauseButtonProfile.onClick.AddListener(() => { });
        UIPauseButtonSettings.onClick.AddListener(() => { });
        UIPauseButtonQuit.onClick.AddListener(() => { SceneManager.LoadScene("Main Menu"); });
    }

    void updateFPSCounter()
    {
        FPSText.text = ((int)(1.0f / Time.smoothDeltaTime)) + " FPS";
    }

    void updateConditionMetersUI()
    {
        CMHealthinessText.SetText(Convert.ToString(Convert.ToInt32(Utilities.getDogHealthiness())));
        CMHappinessText.SetText(Convert.ToString(Convert.ToInt32(Utilities.getDogHappiness())));
        CMSatiationText.SetText(Convert.ToString(Convert.ToInt32(Utilities.getDogSatiation())));
        CMStressText.SetText(Convert.ToString(Convert.ToInt32(Utilities.getDogStress())));
        CMEnergyText.SetText(Convert.ToString(Convert.ToInt32(Utilities.getDogEnergy())));
    }

    void disableAllCameraModesExceptFor(int cameraModeIndex)
    {
        for (int i = 0; i < cameraMode.Length; i++)
        {
            if (cameraModeIndex == i)
            {
                cameraMode[i].enabled = true;
                continue;
            }
            cameraMode[i].enabled = false;
        }
    }
    #endregion
    /* ============================== */


    /* ============================== */
    #region Other Methods
    void generateDogBreedModels()
    {
        if (Utilities.getDogBreed().Equals("P"))
        {
            gameObjectPoodle.SetActive(true);
        }
        else if (Utilities.getDogBreed().Equals("G"))
        {
            gameObjectGermanShepherd.SetActive(true);
        }
        else if (Utilities.getDogBreed().Equals("B"))
        {
            gameObjectBulldog.SetActive(true);
        }
    }
    #endregion
    /* ============================== */

}

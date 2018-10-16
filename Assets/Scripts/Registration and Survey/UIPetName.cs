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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
#endregion
/* ============================== */

public class UIPetName : MonoBehaviour {

    /* ============================== */
    #region Global Variables
    public TMP_InputField textFieldPetName;
    public Button buttonOk;
    #endregion
    /* ============================== */


    /* ============================== */
    #region Override Methods
	void Start () {
        setUpEvents();
	}
	
	void Update () {
		
	}
    #endregion
    /* ============================== */


    /* ============================== */
    #region UI Methods
    void setUpEvents(){
        buttonOk.onClick.AddListener(() =>
        {
            if(textFieldPetName.text.Equals("")){
                return;
            }
            Utilities.initializeConditionMetersWhenStartingGame();
            PlayerPrefs.SetString("DogName", textFieldPetName.text);
           
            PlayerPrefs.SetString("UserRegistered", "Y");
            SceneManager.LoadScene("Main Game");
        });
    }
    #endregion
    /* ============================== */

}


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
#endregion
/* ============================== */

public class UIGenderSelection : MonoBehaviour {

    /* ============================== */
    #region Global Variables
    public Button buttonMale, buttonFemale, buttonChoose;
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
    #endregion
    /* ============================== */

}

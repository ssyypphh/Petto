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

public class UIRecommendedBreed : MonoBehaviour {

    /* ============================== */
    #region Global Variables
    public Image imageBreed;
    public TextMeshProUGUI textBreed, buttonGoWithRecommendedBreedText;
    public Button buttonChooseAnotherBreed, buttonGoWithRecommendedBreed;
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
        buttonChooseAnotherBreed.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Breed Selection");
        });
        buttonGoWithRecommendedBreed.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Gender Selection");
        });
    }
    #endregion
    /* ============================== */

}

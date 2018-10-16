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
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#endregion
/* ============================== */

public class MainMenu : MonoBehaviour {

    /* ============================== */
    #region Global Variables
    public Button buttonPlay, buttonMiniGames, buttonProfile, buttonSettings;
    #endregion
    /* ============================== */


    /* ============================== */
    #region Override Methods
	void Awake()
	{
        Utilities.initializeStartup();
        if (!Utilities.userHasRegistered())
        {
            // If user is not yet registered, go to this scene.
            SceneManager.LoadScene("Registration");
        }
	}

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
        buttonPlay.onClick.AddListener(() => SceneManager.LoadScene("Main Game"));
        buttonMiniGames.onClick.AddListener(() => SceneManager.LoadScene("Mini Games Menu"));
        //buttonProfile.onClick.AddListener(() => SceneManager.LoadScene("Profile"));
        //buttonSettings.onClick.AddListener(() => SceneManager.LoadScene("Settings"));
    }
    #endregion
    /* ============================== */

}
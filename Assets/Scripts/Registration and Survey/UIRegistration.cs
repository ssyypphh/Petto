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
using TMPro;
#endregion
/* ============================== */

public class UIRegistration : MonoBehaviour {

    /* ============================== */
    #region Global Variables
    public TextMeshProUGUI textMessage;
    public TMP_InputField textFieldName;
    public Button buttonOk;
    public TextMeshProUGUI buttonText;

    private bool onSurveyPrompt = false;
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
            if(textFieldName.text.Equals("")){
                return;
            }

            if (!onSurveyPrompt)
            {
                textMessage.SetText(string.Format("Hi {0}!\nBefore we proceed, could I ask you some questions?", textFieldName.text));
                buttonText.SetText("SURE");
                textFieldName.gameObject.SetActive(false);
                onSurveyPrompt = true;
            }
            else{
                SceneManager.LoadScene("Survey");
            }
        });
    }
    #endregion
    /* ============================== */
}

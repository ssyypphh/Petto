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
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#endregion
/* ============================== */

public class UISurvey : MonoBehaviour {

    /* ============================== */
    #region Global Variables
    ArrayList textQuestionArrayList = new ArrayList();
    int currentQuestionIndex = 0;

    public TextMeshProUGUI textQuestion;
    public Button buttonPrevious, buttonNext;
    #endregion
    /* ============================== */


    /* ============================== */
    #region Override Methods
	void Start () {
        setUpQuestions();
        setUpEvents();
	}
	
	void Update () {
		
	}
    #endregion
    /* ============================== */


    /* ============================== */
    #region UI Methods
    void setUpEvents()
    {
        buttonPrevious.onClick.AddListener(() =>
        {
            if (currentQuestionIndex == 0)
            {
                return;
            }
            currentQuestionIndex--;
            textQuestion.SetText(textQuestionArrayList[currentQuestionIndex] as string);
        });
        buttonNext.onClick.AddListener(() =>
        {
            if (currentQuestionIndex == textQuestionArrayList.Count - 1)
            {
                SceneManager.LoadScene("Recommended Breed");
                return;
            }
            currentQuestionIndex++;
            textQuestion.SetText(textQuestionArrayList[currentQuestionIndex] as string);
        });
    }

    void setUpQuestions(){
        textQuestionArrayList.Add("Question 1: What is your favorite color?");
        textQuestionArrayList.Add("Question 2: What is your favorite color?");
        textQuestionArrayList.Add("Question 3: What is your favorite color?");
        textQuestionArrayList.Add("Question 4: What is your favorite color?");
        textQuestionArrayList.Add("Question 5: What is your favorite color?");

        textQuestion.SetText(textQuestionArrayList[currentQuestionIndex] as string);
    }
    #endregion
    /* ============================== */

}

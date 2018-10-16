using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UISurvey : MonoBehaviour {

    ArrayList textQuestionArrayList = new ArrayList();
    int currentQuestionIndex = 0;

    public TextMeshProUGUI textQuestion;
    public Button buttonPrevious, buttonNext;

	// Use this for initialization
	void Start () {
        setUpQuestions();
        setUpEvents();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void setUpQuestions(){
        textQuestionArrayList.Add("Question 1: What is your favorite color?");
        textQuestionArrayList.Add("Question 2: What is your favorite color?");
        textQuestionArrayList.Add("Question 3: What is your favorite color?");
        textQuestionArrayList.Add("Question 4: What is your favorite color?");
        textQuestionArrayList.Add("Question 5: What is your favorite color?");

        textQuestion.SetText(textQuestionArrayList[currentQuestionIndex] as string);
    }

    void setUpEvents(){
        buttonPrevious.onClick.AddListener(() =>
        {
            if(currentQuestionIndex == 0){
                return;
            }
            currentQuestionIndex--;
            textQuestion.SetText(textQuestionArrayList[currentQuestionIndex] as string);
        });
        buttonNext.onClick.AddListener(() =>
        {
            if (currentQuestionIndex == textQuestionArrayList.Count - 1){
                SceneManager.LoadScene("Recommended Breed");
                return;
            }
            currentQuestionIndex++;
            textQuestion.SetText(textQuestionArrayList[currentQuestionIndex] as string);
        });
    }
}

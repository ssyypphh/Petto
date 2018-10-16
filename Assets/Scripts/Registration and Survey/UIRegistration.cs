using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIRegistration : MonoBehaviour {

    public TextMeshProUGUI textMessage;
    public TMP_InputField textFieldName;
    public Button buttonOk;
    public TextMeshProUGUI buttonText;

    private bool onSurveyPrompt = false;

	// Use this for initialization
	void Start () {
        setUpEvents();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

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
}

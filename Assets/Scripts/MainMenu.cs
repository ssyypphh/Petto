// Code Reviewed! (10-05-18)
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Button buttonPlay, buttonMiniGames, buttonProfile, buttonSettings;

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

    void setUpEvents(){
        buttonPlay.onClick.AddListener(() => SceneManager.LoadScene("Main Game"));
        buttonMiniGames.onClick.AddListener(() => SceneManager.LoadScene("Mini Games Menu"));
        //buttonProfile.onClick.AddListener(() => SceneManager.LoadScene("Profile"));
        //buttonSettings.onClick.AddListener(() => SceneManager.LoadScene("Settings"));
    }
}
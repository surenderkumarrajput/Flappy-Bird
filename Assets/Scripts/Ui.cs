using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour {
    public void UpdateScore(int score)
    {
    }
    public void OnStartButtonClick()
    {
        FindObjectOfType<SoundManager>().Play("swoosh");
        SceneManager.LoadScene("LevelMenu");
    }
    public void OnLevel1ButtonClick()
    {
        FindObjectOfType<SoundManager>().Play("swoosh");
        SceneManager.LoadScene("Level1");
    }
    public void OnLevel2ButtonClick()
    {
        FindObjectOfType<SoundManager>().Play("swoosh");
        SceneManager.LoadScene("Level2");
    }
    public void OnLevel3ButtonClick()
    {
        FindObjectOfType<SoundManager>().Play("swoosh");
        SceneManager.LoadScene("Level3");
    }
    public void OnScoreButtonClick()
    {
    }
    public void OnShareButtonClick()
    {

    }
    public void OnExitButtonClick()
    {
        FindObjectOfType<SoundManager>().Play("swoosh");
        Time.timeScale = 1f;
        Application.Quit();
    }
    public void OnPauseButtonClick()
    {

    }
    public void Onrestartclick()
    {

        FindObjectOfType<SoundManager>().Play("swoosh");
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelMenu");
    }
    public void MainMenu()
    {
        FindObjectOfType<SoundManager>().Play("swoosh");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

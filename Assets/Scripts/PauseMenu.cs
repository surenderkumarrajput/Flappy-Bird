using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour {

    public static bool Gamepause = false;
    public GameObject PauseMenuUI;
    public GameObject Option;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Gamepause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        } 
    }
   public void Resume()
    {
        FindObjectOfType<SoundManager>().Play("swoosh");
        Option.SetActive(true);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Gamepause = false;
    }
    public void Pause()
    {
        FindObjectOfType<SoundManager>().Play("swoosh");
        Option.SetActive(false);
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Gamepause = true;
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    Player player;
	public int HighestScore()
    {
        return player.Score();
    }
    private void StartGame()
    {
       
    }
    private void EndGame()
    {

    }
    private void RestartGame()
    {

    }
     void Start()
    {
        StartGame();
    }

}

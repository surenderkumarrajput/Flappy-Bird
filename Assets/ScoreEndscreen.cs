using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEndscreen : MonoBehaviour {

    public Text text12;

    void Update()
    {
        Player p = new Player();
       text12.text= p.Score().ToString();
    }

}

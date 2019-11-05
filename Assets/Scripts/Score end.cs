using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreend : MonoBehaviour {
    public Text text12;
	
	void Start () {
        Player p = new Player();
      string s=  p.Score().ToString();
        text12.text = s;
	}
	
}

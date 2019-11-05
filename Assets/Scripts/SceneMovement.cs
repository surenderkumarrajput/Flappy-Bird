using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMovement : MonoBehaviour {
    public  float speed;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + speed*Vector3.left * Time.deltaTime;
	}
}

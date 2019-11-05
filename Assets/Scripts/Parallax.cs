using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {
    public GameObject cam;
   float position;
     float dist;
    public float parallax ;
    float length;
    private void Start()
    {
        position = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    private void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallax));
        dist = cam.transform.position.x * parallax;
        transform.position = new Vector3(position + dist, transform.position.y, transform.position.z);
        if(temp>position+length)
        {
            position += length;
        }
        else if(temp<position-length)
        {
            position -= length;
        }

    }
}

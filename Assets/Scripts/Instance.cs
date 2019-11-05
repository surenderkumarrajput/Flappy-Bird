using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    
    public GameObject sprite;
    public GameObject pipe;
    public GameObject pipes;
  
  



  
    List<GameObject> pool = new List<GameObject>();
    Transform cameraT;
 
    // Use this for initialization
    void Start()
    {
        cameraT = Camera.main.transform;
        pool.Add(pipe);

        Debug.Log(sprite.GetComponent<SpriteRenderer>().sprite.rect.width);
        Debug.Log(sprite.transform.position);
        float f = sprite.transform.GetComponent<SpriteRenderer>().sprite.rect.width;
        float c = sprite.transform.localScale.x;
        float d = (f * c) / 100;

      
      

            for (int i = 0; i < 5; i++)
        {

            float b = Random.Range(-1.5f, 2.5f);
            GameObject newSprit = Instantiate<GameObject>(pipe);
            newSprit.transform.position = new Vector2(((pipe.transform.position.x) + (i + 1) * d), b);
            newSprit.transform.SetParent(pipes.transform);
           
            pool.Add(newSprit);


        }
      
       
      
    }

    private void Update()
    {
        foreach(var pipe in pool)
        {
            float f = sprite.transform.GetComponent<SpriteRenderer>().sprite.rect.width;
            float c = sprite.transform.localScale.x;
            float d = (f * c) / 100;
            float b = Random.Range(-1.5f, 2.5f);

            if (pipe.transform.position.x + 10 < cameraT.position.x)
            {
                pipe.transform.position = new Vector3(pipe.transform.position.x +  d * pool.Count,  b, pipe.transform.position.z);
            }
           
        }
       
    }

}



    // Update is called once per frame

 
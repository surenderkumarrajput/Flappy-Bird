using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public Rigidbody2D rb;
    private int score;
    public float speed;
    public Text score1,score2;
    public static int count = 0;
    public int highscore;
    public GameObject GameoverUI;
    public GameObject pause;
    public GameObject image;
    public GameObject textt;
    public Text text;
    

    public void OnTriggerEnter2D(Collider2D collision)


    {
        if (collision.gameObject.name == "Pointcollider")
        {
            count++;
            if(count>PlayerPrefs.GetInt("highscore",0))
            {
                PlayerPrefs.SetInt("highscore", count);
                text.text = count.ToString();
            }
           
            FindObjectOfType<SoundManager>().Play("Point");

        }
    }

    public void Gameover()
    {
        GameoverUI.SetActive(true);
        pause.SetActive(false);
        image.SetActive(false);
        textt.SetActive(false);
        Time.timeScale = 0f;
    }
 
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Uppercollider"))
        {

        }
        else
        {            
           
            Destroy(gameObject);
            FindObjectOfType<SoundManager>().Play("die");
            Invoke("die", 0f);
            Gameover();
        }
        }
    public void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(0, 0);
            rb.AddForce(new Vector2(0, speed *Time.deltaTime));
        }
    }
     public int Score()
    {
        score1.text = count.ToString();
        score2.text = score1.text;
        return score;
    }
     void Update()
    {
        Move();
        Score();
    }
    private void Start()
    {
        text.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        
    }
}

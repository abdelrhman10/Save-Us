using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandeler : MonoBehaviour {
    public int health = 1;
    public float delay = 2f;
    public float width = 200;
    public float hight = 30;
    public GameObject exp;
    public bool player = false;
    int playerhealth;
    public float invulnperiod = 0;
    public int scorevalue = 1;
    float invulnetimer = 0;
    public Font myfont;
    int correctlayer;
    public GameObject Score;
    public bool enableexp = false;
    void Start()
    {
        correctlayer = gameObject.layer;
        Score = GameObject.Find("Score");
    }
    void Update()
    {
        invulnetimer -= Time.deltaTime;
        if (invulnetimer <= 0)
        {
            gameObject.layer = correctlayer;
        }
        if(health<=0)
        {
            var scoreScript = Score.GetComponent("Score") as Score;
            scoreScript.ScorePoints += scorevalue ;
            Die();
        }
        if (player)
        {
           playerhealth = health;
        }
        if (playerhealth <= 0 && player)
        {
                Application.LoadLevel("MainMenu");          
        }
    }
    void OnTriggerEnter2D()
    {
        invulnetimer = invulnperiod;
        gameObject.layer = 10;
        health--;
        if (enableexp)
        {
            Instantiate(exp, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    void OnGUI()
    {
        GUI.skin.font = myfont;

        GUI.Label(new Rect(30,10, 100, 50), "lives : "+playerhealth.ToString());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour {
    public float width = 200;
    public float hight = 30;
    public Score scoreMG;
    public int scorepoints;
    public Font myfont;


	void Start () {
		
	}
	
	void Update () {
        if (GameObject.Find("Score"))
        {
            scoreMG = GameObject.Find("Score").GetComponent("Score") as Score;
            scorepoints = scoreMG.ScorePoints;
        }
		
	}
    void OnGUI()
    {
        Rect startbutton = new Rect((Screen.width - width) / 2, (Screen.height  - hight-10) / 2, width, hight);

        if (GUI.Button(startbutton, "START"))
        {
          
            if(GameObject.Find("Score"))
            {
                Destroy(GameObject.Find("Score"));
            }
            Application.LoadLevel("Main");
        }

        Rect exitbutton = new Rect((Screen.width - width) / 2, (Screen.height  + hight+10) / 2, width, hight);

        if (GUI.Button(exitbutton, "EXIT"))
        {
            Application.Quit();
        }
        Rect scorerect = new Rect(Screen.width - 350, 50, 150, 100);
        GUI.skin.font = myfont;
        GUI.Label(scorerect, "Last Score : " +scorepoints.ToString());

    }
}

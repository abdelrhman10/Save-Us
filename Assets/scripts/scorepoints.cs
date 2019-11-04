using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorepoints : MonoBehaviour {
    public Score scoreMG;
    public int myscorepoints;
    public Font myfont;
	void Start () {
		
	}
	
	void Update () {
        myscorepoints = scoreMG.ScorePoints;
	}
    void OnGUI()
    {
        Rect scorerect = new Rect(Screen.width - 200, 20, 150, 50);
        GUI.skin.font = myfont;
        GUI.Label(scorerect, "Score : " + myscorepoints.ToString());
    }
}

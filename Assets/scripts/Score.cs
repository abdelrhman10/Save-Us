using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public int ScorePoints;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}

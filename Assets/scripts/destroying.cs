using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroying : MonoBehaviour {
    private float destroybullettimer = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        destroybullettimer -= Time.deltaTime;
        if (destroybullettimer <= 0)
        {
            Destroy(gameObject);
        }
	}
   
}

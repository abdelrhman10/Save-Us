using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour {
    public float maxspeed=5f;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 velocity = new Vector3(0, maxspeed * Time.deltaTime, 0);
        transform.position += transform.rotation * velocity;
	}
   
}

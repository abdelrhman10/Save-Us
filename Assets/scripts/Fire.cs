using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    
    public GameObject bulletprefab;
    float cooldown = 0;
    public float firedelay = 0.25f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         cooldown-=Time.deltaTime;
         if (Input.GetButton("Fire1") && cooldown <= 0)
         {
             cooldown = firedelay;
             Instantiate(bulletprefab, transform.position, transform.rotation);
             
         }
	}
}

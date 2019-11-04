using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour {
    public float speed;
    public GameObject exp;
    private Vector3 Moving;

	void Start () {
       
	}
	
	void Update ()
    {    
            Movement();
           
	}
    public void Movement()
    {
        Moving.x = Input.GetAxis("Horizontal") * speed; 
        Moving.y = Input.GetAxis("Vertical") * speed;
        transform.position += Moving;        
    }
    void OnTriggerEnter2D()
    {
        
        Instantiate(exp, transform.position, Quaternion.identity);

    }
}

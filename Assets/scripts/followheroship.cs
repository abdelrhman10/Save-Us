using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followheroship : MonoBehaviour {
    public Transform player;
    public float speed;
    public float maxdistance = 20;
    public float rotationspeed = 10;
	void Start () {
        player = GameObject.FindWithTag("Player").transform;
	}
	
	void Update () {
        if (Vector3.Distance(transform.position, player.position) > maxdistance)
        {
            transform.position += (player.position - transform.position).normalized * speed * Time.deltaTime;
        }
         
       // transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), rotationspeed * Time.deltaTime);
	}
}

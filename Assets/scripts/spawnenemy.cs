using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemy : MonoBehaviour {
    public GameObject[] wantedenemy;
    public enum Position
    {
        top,
        down,
    }
    public Position myposition;
    public Vector3 spawnpoint;
    public float maxX = 50;
    public float minX = -50;
    public float maxZ = 50;
    public float minZ = -50;
    public float spawndelay = 5;
	void Start () {
        transform.Rotate(new Vector3(180, 0, 0));
	}
	
	void Update () {
        spawndelay -= Time.deltaTime;

        if (spawndelay <= 0)
        {
            if (myposition == Position.top||myposition == Position.down)
            {
                spawnpoint = new Vector3(Random.Range(minX, maxX), Random.Range(minZ, maxZ), transform.position.z);
                Instantiate(wantedenemy[Random.Range(0, wantedenemy.Length)], spawnpoint,transform.rotation);
                spawndelay = Random.Range(2, 4);
            }
           
        }
	}
}

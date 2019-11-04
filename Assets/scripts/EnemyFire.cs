using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {
    public GameObject bulletprefab;
    float cooldown = 0;
    public float firedelay = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
            cooldown = firedelay;
            GameObject bulletGo = (GameObject)Instantiate(bulletprefab, transform.position, transform.rotation);
            bulletGo.layer = gameObject.layer;
        }
    }
}

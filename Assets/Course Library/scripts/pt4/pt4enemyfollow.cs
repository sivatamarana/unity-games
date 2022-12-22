using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pt4enemyfollow : MonoBehaviour
{

     public float enemyspeed = 3f;
     private Rigidbody pt4enemyrb;
     private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        pt4enemyrb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookdirection = player.transform.position - transform.position.normalized;
        pt4enemyrb.AddForce(lookdirection * enemyspeed);
    }
}

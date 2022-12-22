using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conplayerr : MonoBehaviour
{

    Rigidbody rrb;
    private float Hinput;
    private float Vinput;
    public float Mspeed;
    private float zbouund = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rrb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        playermoment();
        playerlimits();



    }
    //player moment
    void playermoment()
    {
        Hinput = Input.GetAxis("Horizontal");
        Vinput = Input.GetAxis("Vertical");

        rrb.AddForce(Vector3.right * Mspeed * Hinput);
        rrb.AddForce(Vector3.forward * Mspeed * Vinput);

    }
    //player limits
    void playerlimits()
    {
        if (transform.position.z < -zbouund)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zbouund);
        }
        if (transform.position.z > zbouund)
        {
            transform.position = new Vector3(transform.position.z, transform.position.y, zbouund);
        }
    }
}

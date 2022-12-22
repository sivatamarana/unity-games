using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turningspeed = 45f;

    public Camera maincam;
    public Camera hoodcam;
    public KeyCode switchkey;


    private float horiaxis;
   // private float forwardinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horiaxis = Input.GetAxis("Horizontal");
       // forwardinput = Input.GetAxis("Vertical");

        //car moves in forward direction with paricular speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // rotate the car based on the horizantal input
        transform.Rotate(Vector3.up * Time.deltaTime * turningspeed * horiaxis);

        if (Input.GetKeyDown(switchkey))
        {
            maincam.enabled = !maincam.enabled; 
            hoodcam.enabled = !hoodcam.enabled;
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camrot : MonoBehaviour
{
    public float rotspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horiinput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up*horiinput*rotspeed*Time.deltaTime);
    }
}

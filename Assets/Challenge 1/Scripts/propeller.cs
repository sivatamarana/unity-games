using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propeller : MonoBehaviour
{
    public float propspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0,1*propspeed);
    }
}

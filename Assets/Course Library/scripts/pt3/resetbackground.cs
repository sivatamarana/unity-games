using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetbackground : MonoBehaviour
{
    private Vector3 startpos;
    private float repeatwidth;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        // print(startpos);
        repeatwidth = GetComponent<BoxCollider>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.x < startpos.x - repeatwidth)
        {
            // Debug.Log("st =" + startpos.x);
            //   print("x pos ="+transform.position.x);
            transform.position = startpos;// reset the x value to the starting value of the background
        }
    }
}

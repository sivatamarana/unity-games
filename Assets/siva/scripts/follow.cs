using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject targetobj;
    private Vector3 offdistance = new Vector3(0.87f, 7.8f, -8.02f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void  LateUpdate()
    {
        transform.position = targetobj.transform.position + offdistance;
            }
}

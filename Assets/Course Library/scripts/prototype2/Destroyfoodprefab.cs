using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyfoodprefab : MonoBehaviour
{
    private float topbound = 30f;
    private float lowerbound = -10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbound)// for food
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerbound)// aniamlas
        {
            
            Debug.Log("game over");

            Destroy(gameObject);
        }
    }
}

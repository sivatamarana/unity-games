using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horinput;
    public float menspeed;

    public float Xrnage = 15f;

    public GameObject foodprefab;

    Vector3 handpos = new Vector3(-1.8f, 1.2f, 1.1f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodprefab, transform.position + handpos, foodprefab.transform.rotation);
        }

        if (transform.position.x < -Xrnage)    
        {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        if (transform.position.x > Xrnage)
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        horinput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * menspeed * horinput);
    }
}

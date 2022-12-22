using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveleft : MonoBehaviour
{
    public float speed;
    public Playercontrol playercontrolscript;
    public float leftboundary = -15f;
    // Start is called before the first frame update
    void Start()
    {
        playercontrolscript = GameObject.Find("Player").GetComponent<Playercontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playercontrolscript.gameover == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftboundary && gameObject.CompareTag("obstacle"))
            {
            Destroy(gameObject);
        }
    }
}

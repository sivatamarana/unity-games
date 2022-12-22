using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class pt4playaercontroller : MonoBehaviour
{

    Rigidbody rb;
   public int playerspeed;
   private   GameObject focalpoint;

    public bool powerup = false ;
    private int powerupstrenth = 15;
    public GameObject powerupindicator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        focalpoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float verticalinnput = Input.GetAxis("Vertical");

        rb.AddForce(focalpoint.transform.forward * verticalinnput * playerspeed);
        powerupindicator.transform.position = transform.position + new Vector3(0, -.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {   
        if (other.CompareTag("powerup"))// if collide with particular tag then do opertion
        {
            powerupindicator.gameObject.SetActive(true);
            powerup = true;
            Destroy(other.gameObject);
            StartCoroutine(countdownpowerdowntimer());
        }
    }
    IEnumerator countdownpowerdowntimer()
    {
        yield return new WaitForSeconds(5); 
        powerup = false;
        powerupindicator.gameObject.SetActive(false);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("enemy") && powerup){
            Rigidbody enemyrb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayfromplayer = collision.gameObject.transform.position - transform.position;
            enemyrb.AddForce(awayfromplayer * powerupstrenth, ForceMode.Impulse);

        }    }

   
}

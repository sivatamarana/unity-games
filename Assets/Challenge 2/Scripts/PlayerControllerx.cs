using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerx : MonoBehaviour
{
    public GameObject dogPrefab;

    // private float dogInterval = .5f;
    //private float dogTime;

    bool dog  = true;
    private void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog

        if(Input.GetKeyDown(KeyCode.Space)&& dog == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine(dogokaftertime());
        }

       /* if (Input.GetKeyDown(KeyCode.Space) &&  Time.time - dogTime > dogInterval)
        {
            
            dogTime = Time.time;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
            
        }*/



    }
     IEnumerator dogokaftertime()
    {
        dog = false;
        yield return new WaitForSeconds(1f);
        dog = true;
    }
   
}

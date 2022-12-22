using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;

public class spawnmanger : MonoBehaviour
{
    public GameObject[] prefabobstacle;
    private Vector3 spwpos = new Vector3(35, 0, 0);


    private Playercontrol playercontrolscript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("update", 2f, 3f);
        playercontrolscript = GameObject.Find("Player").GetComponent<Playercontrol>();
    }

    // Update is called once per frame
   public  void update()
    {
        int radi = Random.Range(0, prefabobstacle.Length);
        if (playercontrolscript.gameover == false)
        {

            Instantiate(prefabobstacle[radi], spwpos, prefabobstacle[radi].transform.rotation);
        }

    }
}

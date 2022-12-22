using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisionsX : MonoBehaviour
{
   // private int score = 0;
   // public Text scoretext;


    private void OnTriggerEnter(Collider other)
    {
        //scoreincreament();
        scoremanager.instance.scoreincreament();
        Destroy(gameObject);
       // Destroy(other.gameObject);
    }
    /*void scoreincreament()
    {
       // score++;
      //scoretext.text  =  score.ToString();
    }*/
}

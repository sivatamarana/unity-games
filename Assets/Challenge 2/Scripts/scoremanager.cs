using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{
    public static scoremanager instance;

    public int score;
    public Text scoretext;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void scoreincreament()
    {
        score++;
        scoretext.text = score.ToString();
    }
}

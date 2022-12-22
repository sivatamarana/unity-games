using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pt4spawnenemy : MonoBehaviour
{
    public GameObject enemyspwanprefab;
    public float spwanrange = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyspwanprefab, spawing(), enemyspwanprefab.transform.rotation);
    }

    // Update is called once per frame

    private void Update()
    {
        
    }
    Vector3 spawing()
    {
        float spawnX = Random.Range(-spwanrange , spwanrange);
        float spwanZ = Random.Range(-spwanrange, spwanrange);
        Vector3 spawnpos = new Vector3(spawnX, 0, spwanZ);
        return spawnpos;


        
    }
}

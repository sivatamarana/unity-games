using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpwanManager : MonoBehaviour
{
    public GameObject[] animalprefabs;

    private float spawnXpos = 17f;
    private float spawnZpos = 28f;


    public float spawndelay = 2f;
    public float spawnintervel = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnanimals", spawndelay, spawnintervel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawnanimals()
    {

        Vector3 spawnpos = new Vector3(Random.Range(-spawnXpos, spawnXpos), 0, spawnZpos);

        int animalindex = Random.Range(0, animalprefabs.Length);

        Instantiate(animalprefabs[animalindex], spawnpos, animalprefabs[animalindex].transform.rotation);
    }
}

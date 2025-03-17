using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject[] animalprefabs;
    private float Spawnrangex = 20;
    private float Spawnrangez = 20;
    private float Startdelay = 2;
    private float Interval = 1.5f;
     // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnrandomanimal", Startdelay, Interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawnrandomanimal()
    {
        int animalindex = Random.Range(0, animalprefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-Spawnrangex, Spawnrangex), 0, Spawnrangez);
        Instantiate(animalprefabs[animalindex], spawnpos, animalprefabs[animalindex].transform.rotation);
    }
}


﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumerSpawning : MonoBehaviour
{
    public GameObject Spawn;
    public GameObject ObjectToSpawn;
    private Vector2 SpawnVector;
    private int timer;
    private int nextSpawn = 500;
    public static int CurrentCostumers;

    public AudioClip DoorChime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;

        if (timer >= nextSpawn && CurrentCostumers < 5)
        {
            nextSpawn = Random.Range(1000, 3000);
            playSound();
            Instantiate(ObjectToSpawn, Spawn.transform);
            CurrentCostumers++;
            timer = 0;
        }
    }

    void playSound()
    {
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        audio.clip = DoorChime;

        audio.Play();
    }

}

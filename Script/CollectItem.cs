﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour {

    public AudioSource collectSound;
    

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystemMiniGame.theScore += 1;
        Destroy(gameObject);

        
    }


}

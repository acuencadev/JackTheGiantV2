﻿using UnityEngine;

namespace Mantelabs.JackTheGiant.Background
{
    public class BGSpawner : MonoBehaviour
    {
        private GameObject[] _backgrounds;


        private void Awake()
        {
            _backgrounds = GameObject.FindGameObjectsWithTag("Background");    
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TapToInstantiate : MonoBehaviour
{

    private ARRaycastManager rayCastManager;

    private void Awake()
    {
        rayCastManager = GetComponent<ARRaycastManager>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

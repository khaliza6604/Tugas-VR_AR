﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public int jarakRaycast = 20;
    private RaycastHit raycastHit;
    public Material newMaterial;

    // Start is called before the first frame update
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        if (Physics.Raycast(ray, out raycastHit, jarakRaycast))
        {
            if (raycastHit.transform.CompareTag("Cylinder"))
            {
                Renderer objectRenderer = raycastHit.transform.GetComponent<Renderer>();
                if (objectRenderer != null)
                {
                    objectRenderer.material = newMaterial;
                }
            }
        }
    }
}
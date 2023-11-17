using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    private List<Lamp> lamps = new();

    public void Start()
    {
        Lamp[] lampsArray = FindObjectsOfType<Lamp>();
        lamps.AddRange(lampsArray);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (Lamp lamp in lamps)
            {
                lamp.Interact();
            }
        }
    }
}
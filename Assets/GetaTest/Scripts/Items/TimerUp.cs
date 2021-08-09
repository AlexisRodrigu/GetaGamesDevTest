using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TimerUp : Items
{
    private void OnTriggerEnter(Collider other)
    {
       Destroy(gameObject);
    }
}
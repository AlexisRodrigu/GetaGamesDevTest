using System;
using UnityEngine;


public class SpeedUp : GroundMechanics
{
    [SerializeField] private float speedUp;
    private void OnTriggerEnter(Collider other)
    {

        // var kart = other.gameObject.GetComponentInParent<KartMovement>();
        // kart.Speed += speedUp;
    }
}
using UnityEngine;

public class Oil : GroundMechanics
{
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Oil");
    }
}
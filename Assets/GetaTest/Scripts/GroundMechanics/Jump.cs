using UnityEngine;

public class Jump : GroundMechanics
{
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Jump");
    }
}
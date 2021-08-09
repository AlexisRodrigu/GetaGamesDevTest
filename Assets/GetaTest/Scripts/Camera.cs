using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;

    void Update()
    {
     
        transform.position = target.transform.position + new Vector3(0, 1, -5);
        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);
        transform.LookAt(target, Vector3.left);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class KartMovement : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    
    private Vector3 inputVector;

    [SerializeField] private float speedRotation;
    [SerializeField] private float speed;


    private void OnMovement(InputValue value)
    {
        Vector2 inputMovement = value.Get<Vector2>();
        inputVector = new Vector3(inputMovement.x, 0, inputMovement.y);
    }


    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Rotate(0, inputVector.x * Time.deltaTime * speedRotation,0);
        transform.Translate(0,0,inputVector.z * Time.deltaTime * speed);
    }
}

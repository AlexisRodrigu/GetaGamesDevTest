using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CarMovement : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotation;

    private Vector3 inputVector;

  
    void Update()
    {
        Movement();
    }
    private void OnMovement(InputValue value)
    {
        Vector2 inputMovement = value.Get<Vector2>();
        inputVector = new Vector3(inputMovement.x,0,inputMovement.y);
    }
    private void Movement()
    {
        transform.Rotate(0, inputVector.x* Time.deltaTime * _speedRotation, 0);
        transform.Translate(0, 0, inputVector.z * Time.deltaTime * _speed);
    }

   
}

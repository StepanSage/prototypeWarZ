using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveLogica : MonoBehaviour
{
    [SerializeField] private float _speed = 5;

    private float _positionHorizontal;
    private float _positionVertical;
    private const float _minValumPosition = -1;
    private const float _maxValumPosition = 1;
    private Rigidbody _rigidbody;
    private Transform _cameraTransform; 

    public float CurrentPositionHorizontal;
    public float CurrentPositionVertical;

    




    private void Awake()
    {
        if (CurrentPositionHorizontal < _minValumPosition && CurrentPositionHorizontal > _maxValumPosition)
        {
            Debug.Log("привышено значение");
        }

        _rigidbody = GetComponent<Rigidbody>();
        _cameraTransform  = Camera.main.transform;
    }

    private void FixedUpdate()
    {
        Move();
    }
    
      

    public void Move()
    {
       _positionHorizontal = CurrentPositionHorizontal;
       _positionVertical = CurrentPositionVertical;

        var  movement = (_positionVertical * _cameraTransform.forward + _positionHorizontal * _cameraTransform.right).normalized;
        _rigidbody.velocity = movement * _speed;

    }
    
}

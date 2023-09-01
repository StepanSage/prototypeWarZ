using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector3 movement;
    private Rigidbody rb;
    private Transform cameraTransform;

    public Vector3 a;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        cameraTransform = Camera.main.transform;

        
    }

    private void Update()
    {
        // Получить ввод от пользователя
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //// Построить вектор движения на основе ввода и ориентации камеры
        ////Vector3 cameraForward = Vector3.Scale(cameraTransform.forward, new Vector3(1, 0, 1)).normalized;
        movement = (verticalInput * cameraTransform.forward + horizontalInput * cameraTransform.right).normalized;
        
       

        a = new Vector3(verticalInput * cameraTransform.position.x, 0, horizontalInput * cameraTransform.position.z).normalized;

      


      
    }

    private void FixedUpdate()
    {
        // Переместить персонажа в заданном направлении
        rb.velocity = movement * moveSpeed;
    }
}

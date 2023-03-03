using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

    }

    


    
}
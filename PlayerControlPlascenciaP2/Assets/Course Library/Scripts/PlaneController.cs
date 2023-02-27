using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    private float speed = 25.0f;
    private float rotateSpeed = 20.0f;
    
    //private float forwardInput;
    private float rotateInput;
    private float upInput;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    

    // Update is called once per frame
    void Update()
    {
        rotateInput = Input.GetAxis("Horizontal");
        // forwardInput = Input.GetAxis("Vertical");
        upInput = Input.GetAxis("Vertical");
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Rotate(new Vector3(0, 0, 20) * rotateInput * rotateSpeed * Time.deltaTime);

        transform.Rotate(new Vector3(0, 20, 0) * upInput * rotateSpeed * Time.deltaTime);


    }
}
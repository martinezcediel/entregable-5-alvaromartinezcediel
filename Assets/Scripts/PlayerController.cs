using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    public float speed = 30.0f;
    private float verticalInput;
    private float turnSpeed = 40.0f;

    private float zMax = 450.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Posición inicial del player = (0,0,0)
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        verticalInput = Input.GetAxis("Vertical");


        transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime * verticalInput);
            

        if(transform.position.z >= zMax)
        {
            Debug.Log(message: "THE END");
            Time.timeScale = 0;
        }
    }
}

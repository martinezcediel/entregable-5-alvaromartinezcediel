using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    public float speed = 10.0f;
    private float verticalInput;
    private float turnSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Posición inicial del player = (0,0,0)
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * verticalInput);
        }
    }
}

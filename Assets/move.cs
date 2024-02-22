using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float forwardSen;
    public float steerSen;
    public float breakSen;
    public WheelCollider FL;
    public WheelCollider FR;
    public WheelCollider BL;
    public WheelCollider BR; // <-- Add semicolon here

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float forwardSpeed = Input.GetAxis("Vertical") * forwardSen;
        float turningSpeed = Input.GetAxis("Horizontal") * steerSen;

        FL.motorTorque = forwardSpeed;
        FR.motorTorque = forwardSpeed;
        FL.steerAngle = turningSpeed;
        FR.steerAngle = turningSpeed;
    }
}
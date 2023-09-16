using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float motorForce, steerForce, breakForce;
    public WheelCollider wheel_front_left, wheel_front_right, wheel_back_left, wheel_back_right;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical") * motorForce;
        float horizontal = Input.GetAxis("Horizontal") * steerForce;
        Debug.Log(horizontal + vertical);

        wheel_back_left.motorTorque = vertical;
        wheel_back_right.motorTorque = vertical;

        wheel_front_left.steerAngle = horizontal;
        wheel_front_right.steerAngle = horizontal;
    }
}

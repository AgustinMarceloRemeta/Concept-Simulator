using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerRov : MonoBehaviour
{
    WheelCollider[] wheels;
    [SerializeField]  WheelCollider frontL, frontR;
    [SerializeField] float speed, MultiplySpeed, Turn;
    [SerializeField] Slider slider, sliderTurn;
    void Start()
    {
        wheels = FindObjectsOfType<WheelCollider>();
    }


    void Update()
    {

    }

    public void ChangeSpeed()
    {
        foreach (var item in wheels)
        {
            item.motorTorque = speed * slider.value * Time.deltaTime * MultiplySpeed;
        }
    }
    public void ChangeDirection()
    {
      frontL.steerAngle = Turn * sliderTurn.value;
      frontR.steerAngle = Turn * sliderTurn.value;
       
    }
}

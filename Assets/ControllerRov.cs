using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerRov : MonoBehaviour
{
    WheelCollider[] wheels;
    [SerializeField]  WheelCollider frontL, frontR;
    [SerializeField] float speed, multiplySpeed, turn,brake;
    [SerializeField] Slider slider, sliderTurn;
    public bool start;
    void Start()
    {
        wheels = FindObjectsOfType<WheelCollider>();
    }


    void Update()
    {
        if (!start) return;
        foreach (var item in wheels)
        {
            item.motorTorque = speed * slider.value * Time.deltaTime * multiplySpeed;
        }
    }
    public void startBtn()
    {
        start = true;
        foreach (var item in wheels)
        {
            item.brakeTorque = 0;
        }
    }
    public void brakeBtn()
    {
        foreach (var item in wheels)
        {
            item.brakeTorque = brake;
        }
    }
    public void ChangeDirection()
    {
      frontL.steerAngle = turn * sliderTurn.value;
      frontR.steerAngle = turn * sliderTurn.value;
       
    }
}

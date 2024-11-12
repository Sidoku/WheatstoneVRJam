using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToPosition : MonoBehaviour
{
    private GameObject resistance;
    private float resValue;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Resistor"))
        {
            other.gameObject.GetComponent<Transform>().SetPositionAndRotation(new Vector3(1.1569f,1.8632f,1.9673f), new Quaternion(0,0,0,1));
            resistance = GameObject.Find("VoltageCanvas");
            resValue = other.gameObject.GetComponent<ResistanceValue>().GetResistanceValue();
            resistance.gameObject.GetComponent<WheatstoneCalculator>().setResistance1(resValue);
        }
    }
}

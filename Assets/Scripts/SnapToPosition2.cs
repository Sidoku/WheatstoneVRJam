using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToPosition2 : MonoBehaviour
{
    private GameObject resistance;
    private float resValue;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Resistor"))
        {
            other.gameObject.GetComponent<Transform>().SetPositionAndRotation(new Vector3(1.1699f,1.8615f,2.595f), new Quaternion(0,-0.733f,0,0.680f));
            resistance = GameObject.Find("VoltageCanvas");
            resValue = other.gameObject.GetComponent<ResistanceValue>().GetResistanceValue();
            resistance.gameObject.GetComponent<WheatstoneCalculator>().setResistance3(resValue);
        }
    }
}

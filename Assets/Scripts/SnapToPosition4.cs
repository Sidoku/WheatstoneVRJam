using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToPosition4 : MonoBehaviour
{
    private GameObject resistance;
    private float resValue;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Resistor"))
        {
            other.gameObject.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0.564f,1.862f,2.548f), new Quaternion(0,0.0227f,0,0.999f));
            resistance = GameObject.Find("VoltageCanvas");
            resValue = other.gameObject.GetComponent<ResistanceValue>().GetResistanceValue();
            resistance.gameObject.GetComponent<WheatstoneCalculator>().setResistanceUnknown(resValue);
        }
    }
}

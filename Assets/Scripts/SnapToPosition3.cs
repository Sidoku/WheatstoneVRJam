using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToPosition3 : MonoBehaviour
{
    private GameObject resistance;
    private float resValue;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Resistor"))
        {
            other.gameObject.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0.5838f,1.861f,2.0106f), new Quaternion(0,-0.721f,0,0.6922f));
            resistance = GameObject.Find("VoltageCanvas");
            resValue = other.gameObject.GetComponent<ResistanceValue>().GetResistanceValue();
            resistance.gameObject.GetComponent<WheatstoneCalculator>().setResistance2(resValue);
        }
    }
}

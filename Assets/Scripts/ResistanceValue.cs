using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResistanceValue : MonoBehaviour
{
    [SerializeField] private float resistanceValue;

    public float GetResistanceValue()
    {
        return resistanceValue;
    }
}

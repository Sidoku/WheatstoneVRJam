using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WheatstoneCalculator : MonoBehaviour
{
   [SerializeField] private float Resistance_1;
   [SerializeField] private float Resistance_2;
   [SerializeField] private float Resistance_3;
   [SerializeField] private float Resistance_unknown;
   private float Voltage_in = 45.0f;
   [SerializeField] private float Voltage_out;

   private GameObject result;
   private TextMeshPro tmp;
   public TMP_Text vol;

   public void CalculateVoltage()
   {
       float rx = Resistance_unknown / (Resistance_3 + Resistance_unknown);
       float r2 = Resistance_2 / (Resistance_1 + Resistance_2);
       float r2x = rx - r2;
       Voltage_out = Voltage_in * r2x;
      
      Debug.Log(((Resistance_unknown / (Resistance_3 + Resistance_unknown))));
      Debug.Log((Resistance_2 / (Resistance_1 + Resistance_2)));
      //result = GameObject.Find("VoltageResult");
      //tmp = result.GetComponent<TextMeshPro>();
      Debug.Log(Voltage_out);
      vol.text = Voltage_out.ToString("0.000");
   }

   private void CalculateResistance()
   {
       Resistance_unknown = ((Resistance_2 * Resistance_3) +
                             (Resistance_3 * (Resistance_1 + Resistance_2) * (Voltage_out / Voltage_in))) /
                            (Resistance_1 - ((Resistance_1 + Resistance_2) * (Voltage_out / Voltage_in)));
   }

   public void setResistance1(float value)
   {
       Resistance_1 = value;
   }
   
   public void setResistance2(float value)
   {
       Resistance_2 = value;
   }
   
   public void setResistance3(float value)
   {
       Resistance_3 = value;
   }
   
   public void setResistanceUnknown(float value)
   {
       Resistance_unknown = value;
   }

   /*public float GetVoltageOutValue()
   {
       CalculateVoltage();
       return Voltage_out;
   }*/
   
}

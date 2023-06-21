using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Poridge : MonoBehaviour
{
  [SerializeField] private float PorridgeTemperature;
    
    private void Start()
    {
        PorridgeTemperature = 100;
    }

    private void Update()
    {
        PorridgeTemperature = PorridgeTemperature - Time.deltaTime;

        if (PorridgeTemperature > 70)
        {
            Debug.Log("Porridge Temperature Too Hot");
        } 
        else if (PorridgeTemperature < 40)
        {
            Debug.Log("Porridge Temperature Too Cold");
        }
        else    
        {
            Debug.Log("Porridge Temperature Is Just Right!");
        }

    }







}

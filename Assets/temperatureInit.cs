using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temperatureInit : MonoBehaviour
{
    public Slider temperature;
    public float Temp_Handoff = 1f;

    void Awake()
    {
        if (PlayerPrefs.GetFloat("PolarTemp") < 0f)
        {
            PlayerPrefs.SetFloat("PolarTemp", 1f);
        }
        temperature.value = PlayerPrefs.GetFloat("PolarTemp");
        Temp_Handoff = Temp_Handoff - .1f;
    }
    void Update()
    {
        
    }

}

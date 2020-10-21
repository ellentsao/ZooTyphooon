using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("PolarTemp", -1f);
        Debug.Log("polar temp is " + PlayerPrefs.GetFloat("PolarTemp"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

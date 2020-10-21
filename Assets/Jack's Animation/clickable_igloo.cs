using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickable_igloo : MonoBehaviour
{

    void Start() {
        Time.timeScale = 1;
    }
    
    public bool igloo_clicked = false;
    void OnMouseDown()
    {
        igloo_clicked = true;
        Debug.Log("worked");
    }
}
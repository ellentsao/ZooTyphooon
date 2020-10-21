using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep_to_move : MonoBehaviour
{
    public Animator anim;
    public float temp;

    void start(){
        anim = GetComponent<Animator>();
        temp = PlayerPrefs.GetFloat("PolarTemp");
    }

    void Update(){
        temp = PlayerPrefs.GetFloat("PolarTemp");
        if(temp != 1 && anim.GetBool("Sleeping") == true)
        {
            anim.SetBool("Sleeping", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click_sun : MonoBehaviour
{
    public Animator anim;
    public bool sun_clicked = false;

    void start(){
        anim = GetComponent<Animator>();
        Time.timeScale = 1;
    }

    void OnMouseDown()
    {
        sun_clicked = true;
        anim.SetBool("clicked", true);
    }
}

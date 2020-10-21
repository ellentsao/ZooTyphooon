using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomAnim : MonoBehaviour
{
    public Animator anim;
    int randomAnim = Animator.StringToHash("RandomIndex");
    bool animationDone = true;


    void Start()
    {
        RandomDelay();
    }

    void RandomDelay()
    {
        float delay = UnityEngine.Random.Range(1.0f, 5.0f);
        Invoke("PickRandomAnim", delay);
    }

    public void PickRandomAnim()
    {
        if(animationDone)
        {
            anim.SetInteger(randomAnim, UnityEngine.Random.Range(1,3));
            animationDone = false;
        }
    }

    public void RandomAnimationDone()
    {
        anim.SetInteger(randomAnim, -1);
        animationDone = true;
        RandomDelay();
    }
}

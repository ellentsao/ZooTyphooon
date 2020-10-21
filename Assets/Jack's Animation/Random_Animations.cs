using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Animations : StateMachineBehaviour
{
    Polar_Way_Points pwp;
    //GameObject go = GameObject.Find("polar_bear_an2");


    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called before OnStateExit is called on any state inside this state machine
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called before OnStateMove is called on any state inside this state machine
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateIK is called before OnStateIK is called on any state inside this state machine
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        pwp = GameObject.FindGameObjectWithTag("polar_bear_an2").GetComponent<Polar_Way_Points>();
        float temp = PlayerPrefs.GetFloat("PolarTemp");
        //Debug.Log("Rand Result = " + go.GetComponent<Polar_Way_Points>().run_num_finder(temp));
        //Debug.Log("Rand Result = " + pwp.run_num_finder(temp));
        animator.SetInteger("IdleIndex", pwp.run_num_finder(temp));

    }

    // OnStateMachineEnter is called when entering a state machine via its Entry Node
    /*
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        float temp = PlayerPrefs.GetFloat("PolarTemp");
        Debug.Log("PolarTemp = " + temp);
        if(temp >= .9)
        {
            int result =  Random.Range(0,1);
            Debug.Log("Random var made = " + result);
            animator.SetInteger("IdleIndex", result);
        }
        else if(temp >= .8)
        {
            int result =  Random.Range(0,2);
            Debug.Log("Random var made = " + result);
            animator.SetInteger("IdleIndex", result);
        }
        else if(temp >= .7)
        {
            int result =  Random.Range(0,3);
            Debug.Log("Random var made = " + result);
            animator.SetInteger("IdleIndex", result);
        }
        else if(temp >= .6)
        {
            animator.SetInteger("IdleIndex", Random.Range(1,3));
        }
        else if(temp >= .5)
        {
            animator.SetInteger("IdleIndex", Random.Range(1,4));
        }
        else if(temp >= .4)
        {
            animator.SetInteger("IdleIndex", Random.Range(2,4));
        }
        else if(temp >= .3)
        {
            animator.SetInteger("IdleIndex", Random.Range(3,4));
        }
        else if(temp >= .2)
        {
            animator.SetInteger("IdleIndex", Random.Range(4,4));
        }
        else if(temp >= .1)
        {
            animator.SetInteger("IdleIndex", Random.Range(4,4));
        }
    }
*/
    // OnStateMachineExit is called when exiting a state machine via its Exit Node
    //override public void OnStateMachineExit(Animator animator, int stateMachinePathHash)
    //{
    //    
    //}
}

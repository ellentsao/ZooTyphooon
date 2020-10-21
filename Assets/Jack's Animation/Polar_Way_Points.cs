using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polar_Way_Points : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    public float speed;
    public float rotationSpeed;
    int number_out_tester = 0;
    float WPradius = 1;


    public float PTemp = 1;

    void Start() {
        Time.timeScale = 1;
        gameObject.tag = "polar_bear_an2";
    }

    public int run_num_finder(float temp_in)
    {
        if(temp_in >= .9)
        {
            int result =  Random.Range(0,1);
            Debug.Log("Random var made = " + result);
            number_out_tester = result;
            return result;
        }
        else if(temp_in >= .8)
        {
            int result =  Random.Range(0,2);
            Debug.Log("Random var made = " + result);
            number_out_tester = result;
            return result;
        }
        else if(temp_in >= .7)
        {
            int result =  Random.Range(0,3);
            Debug.Log("Random var made = " + result);
            number_out_tester = result;
            return result;
        }
        else if(temp_in >= .6)
        {
            int result =  Random.Range(1,3);
            number_out_tester = result;
            return result;
        }
        else if(temp_in >= .5)
        {
            int result =  Random.Range(1,4);
            number_out_tester = result;
            return result;
        }
        else if(temp_in >= .4)
        {
            int result =  Random.Range(2,4);
            number_out_tester = result;
            return result;
        }
        else if(temp_in >= .3)
        {
            int result =  Random.Range(3,4);
            number_out_tester = result;
            return result;
        }
        else if(temp_in >= .2)
        {
            int result =  Random.Range(4,4);
            number_out_tester = result;
            return result;
        }
        else
        {
            int result =  Random.Range(4,4);
            number_out_tester = result;
            return result;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(number_out_tester == 3)
        {
            PTemp = PlayerPrefs.GetFloat("PolarTemp");
            if(PTemp != 1)
            {
                if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
                    {
                        int temp = current;
                        current = Random.Range(0,3);
                        while(temp == current)
                        {
                            current = Random.Range(0,3);
                        }
                        number_out_tester = 0;
                    }
                transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

                float rotationStep = rotationSpeed * Time.deltaTime;
                Vector3 directionToTarget = waypoints[current].transform.position - transform.position;
                Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);

                transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationStep);
            }
        }
    }
}

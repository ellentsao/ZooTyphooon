using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin_WayPoints : MonoBehaviour
{
    public GameObject[] waypoints;
    public GameObject[] igloo;
    int current = 0;
    float rotSpeed;
    public float speed;
    float WPradius = 1;
    public float rotationSpeed;
    public bool igloo_clicked = false;

    void Start() {
        Time.timeScale = 1;
    }

    void OnMouseDown()
    {
        igloo_clicked = true;
        Debug.Log("worked");
    }

    // Update is called once per frame
    void Update()
    {
        igloo_clicked = GameObject.Find("igloo").GetComponent<clickable_igloo>().igloo_clicked;
        if(igloo_clicked == true)
        {
            if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
                current++;
                if (current >= waypoints.Length)
                {
                    current = 0;
                    GameObject.Find("igloo").GetComponent<clickable_igloo>().igloo_clicked = false;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
            float rotationStep = rotationSpeed * Time.deltaTime;
                Vector3 directionToTarget = waypoints[current].transform.position - transform.position;
                Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);

                transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationStep);
        }
    }

}

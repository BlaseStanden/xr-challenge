using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    ////Rotational Speed////
    public float rotationalSpeed = 0f;

    ////Forward Direction////
    public bool ForwardX = false;
    public bool ForwardY = false;
    public bool ForwardZ = false;

    ////Reverse Direction////
    public bool ReverseX = false;
    public bool ReverseY = false;
    public bool ReverseZ = false;

    ////Forwards and Backwards/Left and right Direction////
    public bool leftToRight;
    public bool upDown;
    public float leftnrightReset;
    public float peak;
    float leftnright;

    void Update()
    {
        leftnright += Time.deltaTime;
        
        if (leftnright >= leftnrightReset)//If the timer hits the assigned value, the timer resets
        {
            leftnright = 0;
        }
        if (upDown == true)//If set to true, in the inspector, the game object transform its position by going up and down the Z axis
        {

            if (leftnright > peak)
            {
                transform.Translate(Vector3.forward * -Time.deltaTime);
            }
            if (leftnright < peak)
            {
                transform.Translate(Vector3.forward * Time.deltaTime);
            }
        }
        if (leftToRight == true)
        {

            if (leftnright > peak)
            {
                transform.Translate(Vector3.left * Time.deltaTime);
            }
            if (leftnright < peak)
            {
                transform.Translate(Vector3.right * Time.deltaTime);
            }
        }

        //Forward Direction
        if (ForwardX == true)//If enabled, the game object will rotate in the assigned direction
        {
            transform.Rotate(Time.deltaTime * rotationalSpeed, 0, 0, Space.Self);
        }
        if (ForwardY == true)
        {
            transform.Rotate(0, Time.deltaTime * rotationalSpeed, 0, Space.Self);
        }
        if (ForwardZ == true)
        {
            transform.Rotate(0, 0, Time.deltaTime * rotationalSpeed, Space.Self);
        }

        //Reverse Direction
        if (ReverseX == true)
        {
            transform.Rotate(-Time.deltaTime * rotationalSpeed, 0, 0, Space.Self);
        }
        if (ReverseY == true)
        {
            transform.Rotate(0, -Time.deltaTime * rotationalSpeed, 0, Space.Self);
        }
        if (ReverseZ == true)
        {
            transform.Rotate(0, 0, -Time.deltaTime * rotationalSpeed, Space.Self);
        }
    }
}

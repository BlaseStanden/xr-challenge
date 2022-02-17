using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    float count;

    public bool leftToRight;

    public bool upDown;

    // Start is called before the first frame update
    void Start()
    {
        //count += 1 * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        count++;

        if (upDown == true)
        {
            if (count == 1000)
            {
                count = 1;
            }
            if (count < 500)
            {
                transform.Translate(Vector3.forward * -Time.deltaTime);
            }
            if (count > 500)
            {
                transform.Translate(Vector3.forward * Time.deltaTime);
            }
        }

        if (leftToRight == true)
        {
            if (count == 1000)
            {
                count = 1;
            }
            if (count < 500)
            {
                transform.Translate(Vector3.left * Time.deltaTime);
            }
            if (count > 500)
            {
                transform.Translate(Vector3.right * Time.deltaTime);
            }
        }


    }
}

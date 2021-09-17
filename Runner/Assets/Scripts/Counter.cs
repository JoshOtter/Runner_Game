using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public static int collisions = 0;
    public static bool end = false;
    Text count;

    void Start()
    {
        count = GetComponent<Text>();
    }

    void Update()
    {
        if (!end)
        {
            count.text = "\nContagions: " + collisions;
        }
        else
        {
            if (collisions == 0)
            {
                count.text = "\nContagions: " + collisions + "\nPERFECT SCORE!\nGREAT JOB!";
            }
            else if (collisions > 0 && collisions <= 10)
            {
                count.text = "\nContagions: " + collisions + "\nIMPRESSIVE SCORE!\n";
            }
            else
            {
                count.text = "\nContagions: " + collisions + "\nYOU MIGHT TURN INTO A ZOMBIE\nTRY AGAIN";
            }
        }
    }
}

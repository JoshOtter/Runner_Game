using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static int collisions = 0;
    Text count;

    void Start()
    {
        count = GetComponent<Text>();
    }

    void Update()
    {
        count.text = "Collisions: " + collisions;
    }
}

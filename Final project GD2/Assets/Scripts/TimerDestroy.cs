using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy : MonoBehaviour
{
    float interval = 22;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

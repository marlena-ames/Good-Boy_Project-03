using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tail : MonoBehaviour
{
    float rotateSpeed = 60f;   

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotateSpeed, 44) - 22);
    }
}

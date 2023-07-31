using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishBehaviour : MonoBehaviour
{
    
    void Update()
    {
        float x=Mathf.MoveTowards(transform.position.x,0, 2.0f * Time.deltaTime);
        float z=transform.position.z+3.0f*Time.deltaTime;
        transform.position = new Vector3(x,0,z);

        float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, 100.0f * Time.deltaTime);
        transform.eulerAngles = new Vector3(0, rot, 0);
    }
}

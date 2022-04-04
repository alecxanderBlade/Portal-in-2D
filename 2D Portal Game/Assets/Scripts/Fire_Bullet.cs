using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Bullet : MonoBehaviour
{
    public GameObject Orange_Bullet, Blue_Bullet;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(Orange_Bullet, transform.position, transform.rotation);
        }
        else if(Input.GetMouseButtonDown(1))
        {
            Instantiate(Blue_Bullet, transform.position, transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Diamond")
        {
            Destroy(other.gameObject);

            
            //Debug.Log(Diamond);


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Diamond")
        {
            Destroy(other.gameObject);

            
            //Debug.Log(Diamond);


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    protected int Stars = 0;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Star")
        {
            Destroy(other.gameObject);

            Stars ++;
            Debug.Log(Stars);


        }
    }
}

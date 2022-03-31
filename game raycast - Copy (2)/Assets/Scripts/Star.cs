using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public int StarNm = 0;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Star")
        {
            Destroy(other.gameObject);

            StarNm ++;
            //Debug.Log(Stars);


        }
    }
}

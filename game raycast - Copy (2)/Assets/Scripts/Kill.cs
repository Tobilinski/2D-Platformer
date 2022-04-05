using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public GameObject Enemy;
    
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.gameObject.tag == "Kill")
        {
            Debug.Log("Hit");
            Destroy(Enemy.gameObject);
        }


    }
    
}

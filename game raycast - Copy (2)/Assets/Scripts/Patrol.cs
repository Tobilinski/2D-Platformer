using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//guide used.
//Name of Video: 2D PLATFORMER PATROL AI WITH UNITY AND C# - EASY TUTORIAL
//Author: Blackthornprod
//Date of publish: Feb 7, 2018


public class Patrol : MonoBehaviour
{
    public float speed;
    
    private bool _movingRight = true;

    public Transform groundDetection;
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 0.1f);
        if (groundInfo.collider == false)
        {
            if (_movingRight == true)
            {
                transform.eulerAngles = new  Vector3(0, -180, 0);
                _movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                _movingRight = true;
            }
        }
    }
    
    

}

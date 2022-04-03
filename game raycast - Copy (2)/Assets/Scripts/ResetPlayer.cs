using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour

{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            transform.position = new Vector3(-16.15f, -6.05f, 0f);
        }

        if(other.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(-15.88f, -5.07f, 0f);
        }
    }
}

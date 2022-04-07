using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour
{
    public Text ScoreKey;
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
    private void Update()
    {
        ScoreKey.text = "Stars: " + StarNm;
    }
}

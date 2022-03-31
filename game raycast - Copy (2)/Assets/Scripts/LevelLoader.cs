using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   
public class LevelLoader : MonoBehaviour
{
    public Animator Trans;
    public float TransTime = 1f;

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0)) {
            NextLevel();
        }*/
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            Debug.Log("null");
        }
    }

    public void NextLevel()
    {
        
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        Trans.SetTrigger("Start");

        yield return new WaitForSeconds(TransTime);

        SceneManager.LoadScene(levelIndex);
    }
}

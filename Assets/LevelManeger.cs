using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManeger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Damage")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.gameObject.tag == "Fall")
        {
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        if (other.gameObject.tag == "Button")
        {
            Debug.Log("Pressed");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.gameObject.tag == "GameOver")
        {
            SceneManager.LoadScene("GameOverMenu");
        }
    }



    public void LoadFirstScene()
    {
        SceneManager.LoadScene("Level1");
    }

}

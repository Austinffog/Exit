using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    private int nextSceneToLoad;

    private int interval = 30;

    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;

        Invoke("ChangeColor", interval);
    }


    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }

    private void ChangeColor()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Seventy Seven"))
        {
            Color newColor = new Color(0, 0, 0);
            GetComponent<Renderer>().material.color = newColor;
        }
    }
}


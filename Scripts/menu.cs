using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject about;


    int activeState1 = 0;

    public void Start()
    {
        about.SetActive(false);
    }

    public void descAbout()
    {
        if (activeState1 == 0)
        {
            about.SetActive(true);

            activeState1 = 1;
        }
        else if (activeState1 == 1)
        {
            about.SetActive(false);

            activeState1 = 0;
        }
    }
    

    public void main()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

    public void exit()
    {
        Application.Quit();
    }
}


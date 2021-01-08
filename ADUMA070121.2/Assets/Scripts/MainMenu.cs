﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    void Start()
    {
        transition.gameObject.SetActive(false);
    }

    public void PlayGame()
    {
       
       StartCoroutine(loadTut("Tutorial"));
        
    }

    

    IEnumerator loadTut(string levelIndex)
    {
        transition.SetTrigger("Start");
        transition.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelIndex);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

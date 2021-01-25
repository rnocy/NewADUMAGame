using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public AudioSource mySFX;
    public AudioClip hoverSFX;
    public AudioClip clickSFX;

    void Start()
    {
        transition.gameObject.SetActive(false);
    }

    public void PlayGame()
    {
        //SceneManager.LoadScene("Tutorial");
        StartCoroutine(loadTut("Tutorial"));

    }



    IEnumerator loadTut(string levelIndex)
    {
       // Debug.Log("Load tutorial");
        transition.SetTrigger("start");
        transition.gameObject.SetActive(true);
        //Debug.Log("Load tutorial-1");
        yield return new WaitForSeconds(1);
        //Debug.Log("Load tutorial-2");
        SceneManager.LoadScene(levelIndex);
        //Debug.Log("Load tutorial-3");

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HoverSound()
    {
        mySFX.PlayOneShot(hoverSFX);
    }

    public void ClickSound()
    {
        mySFX.PlayOneShot(clickSFX);
    }
}

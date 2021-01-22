using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlotScene : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    void Start()
    {
        transition.gameObject.SetActive(false);
    }

    public void Next()
    {

        StartCoroutine(loadPlot("TutorialRound"));

    }



    IEnumerator loadPlot(string levelIndex)
    {
        transition.SetTrigger("Start");
        transition.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelIndex);

    }
}

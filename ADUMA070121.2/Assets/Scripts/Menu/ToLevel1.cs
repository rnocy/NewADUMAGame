using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel1 : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    void Start()
    {
        transition.gameObject.SetActive(false);
    }

    public void Next()
    {

        StartCoroutine(loadLevelOne("FirstLevel"));

    }



    IEnumerator loadLevelOne(string levelIndex)
    {
        transition.SetTrigger("Start");
        transition.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelIndex);

    }
}

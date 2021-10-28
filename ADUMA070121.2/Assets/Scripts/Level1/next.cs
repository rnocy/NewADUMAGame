using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("Wining1");
    }

    public void NextNext()
    {
        SceneManager.LoadScene("Wining2");
    }
}

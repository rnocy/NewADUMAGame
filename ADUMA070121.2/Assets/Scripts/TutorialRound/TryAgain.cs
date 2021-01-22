using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public string sceneName;
    public void RePlay()
    {
        SceneManager.LoadScene(sceneName);
        Typer2.boo_gameOver = false;
        Timer2.boo_stop = false;
        Typer.boo_gameOver = false;
        Timer.boo_stop = false;
    }


}

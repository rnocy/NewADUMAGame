using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay_2 : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene("FirstLevel");
    }
}

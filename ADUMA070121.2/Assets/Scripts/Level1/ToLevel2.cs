using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel2 : MonoBehaviour
{
    public void ToLevelTwo()
    {
        SceneManager.LoadScene("SecondLevel");
    }
}

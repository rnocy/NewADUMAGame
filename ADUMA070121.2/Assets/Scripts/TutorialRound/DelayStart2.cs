using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayStart2 : MonoBehaviour
{
    public GameObject countDown;
    public Typer2 scr_ty;
    public GameObject menuButton2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartDelay");
        menuButton2.gameObject.SetActive(false);

    }

    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 4f;
        while (Time.realtimeSinceStartup < pauseTime)
            yield return 0;
        countDown.gameObject.SetActive(false);
        Time.timeScale = 1;
        scr_ty.enabled = true;
        scr_ty.fn_init();
        menuButton2.gameObject.SetActive(true);
    }
}

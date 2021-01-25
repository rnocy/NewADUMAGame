﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject TryOutButton;

    void Start()
    {
        StartCoroutine(Type());
         TryOutButton.gameObject.SetActive(false);
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.gameObject.SetActive(true);
           
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.gameObject.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            TryOutButton.gameObject.SetActive(true);
        }
    }


}

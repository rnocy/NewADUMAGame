﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_Button : MonoBehaviour
{
    public AudioSource mySFX;
    public AudioClip hoverSFX;
    public AudioClip clickSFX;

    public void HoverSound()
    {
        mySFX.PlayOneShot(hoverSFX);
    }

    public void ClickSound()
    {
        mySFX.PlayOneShot(clickSFX);
    }
        
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip corect, gresit, buton;
    public void PlayAudioCorect()
    {
        src.clip = corect;
        src.Play();
    }
    public void PlayAudioGresit()
    {
        src.clip = gresit;
        src.Play();
    }
    public void PlayAudioButon()
    {
        src.clip = buton;
        src.Play();
    }
}

﻿using UnityEngine.Audio;

using UnityEngine;
[System.Serializable]
public class Audio
{
   public bool loop;
    public string name;
    public AudioClip clip;
    [Range(0f,1f)]
    public float volume;
    [Range(.1f,1f)]
    public float pitch;
    [HideInInspector]
    public AudioSource audios;
}

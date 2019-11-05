using UnityEngine.Audio;
using UnityEngine;
using System;

public class SoundManager : MonoBehaviour {
    public Audio[] sound;
    public static SoundManager instance;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
     foreach(Audio a in sound)
        {
          a.audios=  gameObject.AddComponent<AudioSource>();
            a.audios.clip = a.clip;
            a.audios.volume = a.volume;
            a.audios.pitch = a.pitch;
            a.audios.loop = a.loop;


        }
     if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        Play("theme");
    }
    public void Play(String name)
    {
        Audio s=Array.Find(sound, sound => sound.name == name);
        s.audios.Play();
    }
}

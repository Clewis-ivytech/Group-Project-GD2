using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    [SerializeField] AudioSource audioSource;
    private int currentMusic = 1;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
        }
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            currentMusic ++;
            if (currentMusic == 7)
            {
                currentMusic = 1;
            }
            PlayMusic();
        }
    }

    void PlayMusic()
    {
        if (currentMusic == 1)
        {
            Play("Music1");
        }
        else if (currentMusic == 2)
        {
            Play("Music2");
        }
        else if (currentMusic == 3)
        {
            Play("Music3");
        }
        else if (currentMusic == 4)
        {
            Play("Music4");
        }
        else if (currentMusic == 5)
        {
            Play("Music5");
        }
        else if (currentMusic == 6)
        {
            Play("Music6");
        }
    }

    public void Play (string name)
    {
        Sound s = System.Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
}

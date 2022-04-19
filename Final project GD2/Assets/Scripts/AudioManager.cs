using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public Sound[] music;

    public static AudioManager instance;

    [SerializeField] AudioSource audioSource;
    public int level;
    public int constlevel = 0;

    private int mute;

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
            s.source.loop = s.loop;
        }

        foreach (Sound s in music)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        Sound s = System.Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
        if (s == null)
        {
            Debug.LogWarning("Audio null");
            return;
        }
    }

    public void OnNewLevel()
    {
        if (level == 0)
        {
            ChangeBGM("0");
        }
        else if (level == 1)
        {
            ChangeBGM("1");
        }
        else if (level == 2)
        {
            ChangeBGM("2");
        }
        else if (level == 3)
        {
            ChangeBGM("3");
        }
        else if (level == 4)
        {
            ChangeBGM("4");
        }
        else if (level == 5)
        {
            ChangeBGM("5");
        }
    }

    public void ChangeBGM(string name)
    {
        Sound s = System.Array.Find(music, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Audio null");
            return;
        }
        s.source.Play();
    }

    public void Load()
    {
        if (level == 0)
        {
            constlevel = level;
            OnNewLevel();
        }
        else if (level != constlevel)
        {
            constlevel = level;
            OnNewLevel();
        }
    }

    public void Update()
    {
        mute = PlayerPrefs.GetInt("Mute");
        if (mute == 1)
        {
            gameObject.GetComponent<AudioListener>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<AudioListener>().enabled = true;
        }
    }
}

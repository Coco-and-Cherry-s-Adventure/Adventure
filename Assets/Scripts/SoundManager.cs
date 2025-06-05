using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance { get; private set; }
    private AudioSource soundSource;
    private AudioSource musicSource;

    private void Awake()
    {

        soundSource = GetComponent<AudioSource>();
        musicSource = transform.GetChild(0).GetComponent<AudioSource>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != null && instance != this)
            Destroy(gameObject);
    }
    public void PlaySound(AudioClip _sound, float volume = 1f)
    {
        soundSource.PlayOneShot(_sound, volume);
    }

    public void ChangeSoundVolume(float _change)
    {
        float currentVolume = PlayerPrefs.GetFloat("soundVolume", 1);
        currentVolume += _change;

        if (currentVolume > 1)
            currentVolume = 0;
        else if (currentVolume < 0)
            currentVolume = 1;

        soundSource.volume = currentVolume;

        PlayerPrefs.SetFloat("soundVolume", currentVolume);
    }

    public void ChangMusicVolume(float _change)
    {
        float currentVolume = PlayerPrefs.GetFloat("musicVolume", 1);
        currentVolume += _change;

        if (currentVolume > 1)
            currentVolume = 0;
        else if (currentVolume < 0)
            currentVolume = 1;

        musicSource.volume = currentVolume;

        PlayerPrefs.SetFloat("musicVolume", currentVolume);
    }
}
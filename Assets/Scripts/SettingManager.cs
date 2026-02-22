using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager instance;

    public bool musicOn = true;
    public bool sfxOn = true;

    // ✅ Assign in Inspector
    public AudioSource musicSource;
    public AudioSource[] sfxSources;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ✅ MUSIC TOGGLE (NOW CONTROLS SOUND)
    public void ToggleMusic()
    {
        musicOn = !musicOn;

        if (musicSource != null)
            musicSource.mute = !musicOn;

        Debug.Log("Music: " + (musicOn ? "ON" : "OFF"));
    }

    // ✅ SFX TOGGLE (NOW CONTROLS SOUND)
    public void ToggleSFX()
    {
        sfxOn = !sfxOn;

        if (sfxSources != null)
        {
            foreach (AudioSource sfx in sfxSources)
            {
                if (sfx != null)
                    sfx.mute = !sfxOn;
            }
        }

        Debug.Log("SFX: " + (sfxOn ? "ON" : "OFF"));
    }

    // ✅ BACKGROUND COLOR (OPTIONAL FEATURE)
    public void ChangeColor()
    {
        if (Camera.main != null)
        {
            Camera.main.backgroundColor =
                new Color(Random.value, Random.value, Random.value);
        }
    }
}


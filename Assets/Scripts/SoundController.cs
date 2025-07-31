using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;    

    private void Awake()
    {
        instance = this;
    }
    public void PlayThisSound(string clipName, float volumeMultiplier)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.volume *= volumeMultiplier;
        audioSource.PlayOneShot((AudioClip)Resources.Load("Sounds/" + clipName, typeof(AudioClip)));
    }
    
    void Start()
    {

    }

    void Update()
    {

    }

    public float GetSoundDuration(string soundName)
    {
        AudioClip loadedClip = (AudioClip)Resources.Load("Sounds/" + soundName, typeof(AudioClip));

        if (loadedClip != null)
        {
            return loadedClip.length; 
        }
        Debug.LogWarning($"Sound clip '{soundName}' not found or null when trying to get duration.");
        return 0f; 
    }
}

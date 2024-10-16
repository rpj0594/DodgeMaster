using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip clip;

    public AudioMixer audioMixer;
    public Slider MasterSlider;
    public Slider BGMSlider;
    public Slider SFXSlider;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayAudio();
        }
        UpdateAudioMixer();
    }



    public void UpdateAudioMixer()
    {
        audioMixer.SetFloat("Master_Volume", MasterSlider.value);
        audioMixer.SetFloat("BGM_Volume", BGMSlider.value);
        audioMixer.SetFloat("SFX_Volume", SFXSlider.value);
    }

    void PlayAudio()
    {
        //Audio plays from beginning of level 
        audioSource.Play();
    }

    void StopAudio()
    {
        //Audio stops playing when player dies
        audioSource?.Stop();
    }



}

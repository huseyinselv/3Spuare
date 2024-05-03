using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField]
    Slider slider;

    float vol = 1f;
    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        audioSource = GetComponent<AudioSource>();
        slider.value = vol;
    }
    public void Update()
    {
        audioSource.volume = vol;
    }
    public void ChangeValume(float vol)
    {
        this.vol = vol;
    }
}

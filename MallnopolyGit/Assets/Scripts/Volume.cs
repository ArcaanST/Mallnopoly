using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    float volumeMusic;
    public Slider sliderMusic;
    void Start()
    {
        sliderMusic.value = PlayerPrefs.GetFloat("Music");
    }

    public void VolumeMusic(float volume)
    {
        volumeMusic = volume;
        GameObject[] Mus = GameObject.FindGameObjectsWithTag("Music");
        for (int i = 0; i < Mus.Length; i++)
        {
            Mus[i].GetComponent<AudioSource>().volume = volumeMusic;
        }
        PlayerPrefs.SetFloat("Music", volumeMusic);
    } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volSlider : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    
    void Start()
    {
        if (PlayerPrefs.HasKey("musicaVolume"))
        {
            PlayerPrefs.SetFloat("musicaVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicaVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicaVolume", volumeSlider.value);
    }
}

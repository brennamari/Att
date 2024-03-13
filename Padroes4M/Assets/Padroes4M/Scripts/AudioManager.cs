using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    
    public static AudioManager Instance
    {
        get
        {
            return instance;
        }
    }

    public float Volume = 0.5f;
    
    [SerializeField] private float volume;

    private void Awake()
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

    private void OnEnable()
    {
        AudioObserverManager.OnVolumesSliderValueChanged += ProcessVolumeChanged;
    }

    private void OnDisable()
    {
        AudioObserverManager.OnVolumesSliderValueChanged -= ProcessVolumeChanged;
    }

    private void ProcessVolumeChanged(float newVolume)
    {
        volume = newVolume;
    }

    public float Vol
    {
        get
        {
            return volume;
        }
        set
        {
            volume = Mathf.Clamp01(value);
        }
    }
    
    
    
    
}

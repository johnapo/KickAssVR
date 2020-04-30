using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolumeV2 : MonoBehaviour
{
    public AudioSource Smash;
    public Slider slider;
 

    float volume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Smash.volume = slider.value;

    }

    // Update is called once per frame
    void Update()
    {
        Smash.volume = slider.value;
 
    }
}

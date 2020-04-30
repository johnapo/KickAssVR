using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessV2 : MonoBehaviour
{

    public Slider brightnessSlide;
    public Image image;

    float rbgValue = 0.1f;

    public void OnGUI()
    {
        rbgValue = brightnessSlide.value;
    }

    // Update is called once per frame
    void Update()
    {
        image.color = new Color(0, 0, 0, rbgValue);
    }
}

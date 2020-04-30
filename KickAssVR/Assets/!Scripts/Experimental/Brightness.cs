using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{

    public Slider brightnessSlide;

    float rbgValue = 0.5f;

 //   public void OnGUI()
 //   {
  //      rbgValue = brightnessSlide.value;
 //   }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.ambientLight = new Color(rbgValue, rbgValue, rbgValue, 1);
    }
}

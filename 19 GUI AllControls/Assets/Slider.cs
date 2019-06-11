using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour {

    
     
        public float hSliderValue = 0.0F;

        void OnGUI()
        {

        //public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb);
        hSliderValue = GUI.HorizontalSlider(new Rect(0, 80, 100, 30), hSliderValue, 0.0F, 10.0F);
        }
    
}

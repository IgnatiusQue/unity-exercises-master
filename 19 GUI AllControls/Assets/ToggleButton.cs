using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour {
    public bool toggleButton = true;
    void OnGUI () { 
    toggleButton = GUI.Toggle(new Rect(0, 125, 100, 20), toggleButton, "Toggle 0");
	}
	 
}

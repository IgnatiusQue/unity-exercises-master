using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbar : MonoBehaviour {

    public int toolbarInt = 0;
    public string[] toolbarStrings = new string[] { "Toolbar1", "Toolbar2", "Toolbar3" };

    void OnGUI()
    {
        toolbarInt = GUI.Toolbar(new Rect(0, 0, 250, 30), toolbarInt, toolbarStrings);
    }




}

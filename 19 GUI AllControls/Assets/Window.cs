using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour {
    Rect windowRect = new Rect(20, 20, 120, 50);

     void OnGUI()
    {
        // Register the window.
        windowRect = GUI.Window(0, windowRect, DoMyWindow, "My Window");

        //test
        if (GUI.changed)  { print("gui has changed."); }
    }

    // Make the contents of the window
    void DoMyWindow(int windowID )
    {
        if (GUI.Button(new Rect(10, 20, 100, 20), "Hello World"))
        {
            print("Got a click in window " + windowID);
        }
        // This will make the window be resizable by the top title bar - no matter how wide it gets
        //  GUI.DragWindow(new Rect(0, 0, 10000, 100000));
        GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
    }
}

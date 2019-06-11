using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTexture : MonoBehaviour {

    public Texture aTexture;

    void OnGUI()
    {
        if (!aTexture)
        {
            Debug.LogError("Assign a Texture in the inspector.");
            return;
        }

        GUI.DrawTexture(new Rect(0, 50, 30, 20), aTexture, ScaleMode.StretchToFill, true, 10.0F);
    }
}

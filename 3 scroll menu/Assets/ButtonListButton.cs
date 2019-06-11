using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListButton : MonoBehaviour {

    [SerializeField]
    private Text myText;

    [SerializeField]
    private ButtonListControl ButtonControl;

    private string  ASimpleString;
	// Use this for initialization
 public	void SetText (string text) {
        myText.text = text;
        ASimpleString = text;

    }


      void OnClick () {
        ButtonControl.ButtonClicked(ASimpleString);
        print("Click");
        print(ASimpleString);

	}
}

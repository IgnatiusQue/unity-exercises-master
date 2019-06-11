using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonListControl : MonoBehaviour {

    [SerializeField]
    private GameObject buttonTemplate;
    // Use this for initialization

  

	void Start () {
        print("Hello");
        for (int i = 0;i<30;i++) {
            GameObject button = Instantiate(buttonTemplate) as GameObject;
            button.SetActive(true);

            button.GetComponent<ButtonListButton>().SetText("Buttonz " + i);
            button.transform.SetParent(buttonTemplate.transform.parent,false);
        }
	}
	
	// Update is called once per frame
	public void ButtonClicked (string myTextString) {
     print(myTextString);
	}
}

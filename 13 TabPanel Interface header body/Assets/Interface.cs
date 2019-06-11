using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour {

    public GameObject header;
    public GameObject body;
	void Start () {
        //   GameObject fullBodyPanel = body.transform.Find("FullBodyPanel").GetComponent<GameObject>(); 
     //   togglePanel("FullBodyPanel");
      
    }
	
	// Update is called once per frame
	public void togglePanel (string name) {
        GameObject fullBodyPanel = GameObject.Find("Interface/Body/"+name);

        if (fullBodyPanel.activeInHierarchy)
        {
            fullBodyPanel.SetActive(false);
        }
        else {
            fullBodyPanel.SetActive(true);
        }

       
    }



    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
    }
}

using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Index : MonoBehaviour {
    JSONNode player;
    // Use this for initialization
    void Start () {
       player = JSON.Parse("{\"id\":123}");
        print(player["id"]);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

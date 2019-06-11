using SimpleJSON;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Index : MonoBehaviour {

    PlayerList p = new PlayerList();
    // Players players new Players();
    // players.add();

    //JSONNode Players;
    // Use this for initialization
    void Start () {
  
    
         
        p.players.Add(new Player(1, 0, "Japan"));
        p.players.Add(new Player(9, 2, "China"));

        print(p.players[1].Civname);
         
    }

}
	

 
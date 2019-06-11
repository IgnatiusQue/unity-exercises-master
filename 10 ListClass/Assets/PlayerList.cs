using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PlayerList
{

    //  public JSONNode Players  { get; set; }
    public List<Player> players;
    public PlayerList()
    {
          players = new List<Player>();
    }


    public void Add(Player player)
    {
        players.Add(player);
     //   return 2013 - Age;
    }
}


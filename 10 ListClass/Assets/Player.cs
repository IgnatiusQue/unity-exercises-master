using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player

{
    // public Coroutine Coroutine { get; private set; }
    // public object result;
    // private IEnumerator target;
    public int Uid { get; set; }
    public int Gid { get; set; }
    public string Civname { get; set; }
 
    public Player(int uid, int gid, string civname)
    {


        Uid = uid;
        Gid = gid;
        Civname = civname;

    }
  /*  public string name()
    {
        return Name;
        
    }*/



    
}
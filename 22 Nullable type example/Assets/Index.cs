using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public   class Index : MonoBehaviour {

    // Use this for initialization

    public void Test1(Vector2 item = default(Vector2))
    {

        if (item == default(Vector2))
        {
            print("nulll!!!");
        }
        else
        {
            print("NOT nulll!!!");


        }

    }
    public   void Test2(Aclass item=default(Aclass))
    {
    
        if (item== default(Aclass)) {
           
            print("  nulll!!!");

        }
        else {
            print(item.show());

        }

    }


    public void Identity(string name, int id)
    {

        Console.WriteLine("Name : " + name + ", "
                          + "Id : " + id);
    }

    // Method 
    public void Identity(int id, string name)
    {

        Console.WriteLine("Name : " + name + ", "
                          + "Id : " + id);
    }

    // Main Method 
    public static void Main(Component[] args)
    {

        args[].
        // Creating Object 
        //GFG obj = new GFG();

       // obj.Identity("Akku", 1);
       // obj.Identity("Abby", 2);
    }
}


void Start () {
        Aclass a1 = new Aclass();
      //  Test1();
      //  Test1(a1);
	}
	
	// Update is called once per frame
	void Update () {
	 
	}
}

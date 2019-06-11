using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using RTS;

public class HUD : MonoBehaviour {
    public GUISkin resourceSkin, ordersSkin, selectBoxSkin;
    private const int ORDERS_BAR_WIDTH = 150, RESOURCE_BAR_HEIGHT = 40;

    
    private const int SELECTION_NAME_HEIGHT = 15;

 

    // Use this for initialization
    void Start () {
      


     //   ResourceManager.StoreSelectBoxItems(selectBoxSkin);
    }

 
    void OnGUI()
    {
        if (true)
        {
            DrawOrdersBar();
            DrawResourcesBar();
        }
    }

    private void DrawOrdersBar()
    {
       
        GUI.skin = ordersSkin;
        GUI.BeginGroup(new Rect(Screen.width - ORDERS_BAR_WIDTH, RESOURCE_BAR_HEIGHT, ORDERS_BAR_WIDTH, Screen.height - RESOURCE_BAR_HEIGHT));
        GUI.Box(new Rect(0, 0, ORDERS_BAR_WIDTH, Screen.height - RESOURCE_BAR_HEIGHT), "");
       
        // Selected object start
        string selectionName = "A NAME";

         
       
            //print("selectionName: " + selectionName);
            GUI.Label(new Rect(0, 10, ORDERS_BAR_WIDTH, SELECTION_NAME_HEIGHT), selectionName); 
        // Selected object end
        GUI.EndGroup();
    }


    private void DrawResourcesBar()
    {
        GUI.skin = resourceSkin;
        GUI.BeginGroup(new Rect(0, 0, Screen.width, RESOURCE_BAR_HEIGHT));
        GUI.Box(new Rect(0, 0, Screen.width, RESOURCE_BAR_HEIGHT), "");
        GUI.EndGroup();
    }
    public bool MouseInBounds()
    {
        //Screen coordinates start in the lower-left corner of the screen
        //not the top-left of the screen like the drawing coordinates do
        Vector3 mousePos = Input.mousePosition;
        bool insideWidth = mousePos.x >= 0 && mousePos.x <= Screen.width - ORDERS_BAR_WIDTH;
        bool insideHeight = mousePos.y >= 0 && mousePos.y <= Screen.height - RESOURCE_BAR_HEIGHT;
        return insideWidth && insideHeight;
    }

    public Rect GetPlayingArea()
    {
        return new Rect(0, RESOURCE_BAR_HEIGHT, Screen.width - ORDERS_BAR_WIDTH, Screen.height - RESOURCE_BAR_HEIGHT);
    }

}

using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Index : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(WaitForRequest("http://localhost/jmpf/map/php/webservice/player.load.all.php", (result) => {
            print(result[0]["uid"]);
        }));
    }



    private IEnumerator WaitForRequest(string url, System.Action<JSONNode> callback)
    {  //todo data
        WWWForm form = new WWWForm();
        form.AddField("gid", "1");
        WWW www = new WWW(url, form);
        JSONNode tempInt = null;
        yield return www;
        if (string.IsNullOrEmpty(www.error))
        {
            /*   if (!string.IsNullOrEmpty(www.text))
               {
                   tempInt = 3;
               }
               else
               {
                   tempInt = 2;
               }*/
    
            tempInt = JSON.Parse(www.text + "");
        }
        else
        {
            print(www.error);
            tempInt = null;
        }
        callback(tempInt);
    }

}

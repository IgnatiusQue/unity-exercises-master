using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diapositiva {
    public string tit;
    public string desc;
    public Sprite foto;


    //Constructor
    public Diapositiva(string _tit,string _desc, string _foto) {
        tit = _tit;
        desc = _desc;
        foto = Resources.Load<Sprite>(_foto); 


    }
}

public class Index : MonoBehaviour {
    public Text Titulo;
    public Text Desc;
    public Image Foto;
    // Use this for initialization
    public List<Diapositiva> Diapositivas = new List<Diapositiva>();
    public int currentPosition = 0;
	void Start () {


 Diapositivas.Add(new Diapositiva("Everest", "88009 asdas", "Images/Everest"));
 Diapositivas.Add(new Diapositiva("K2", "88009 asdas", "Images/K2"));
 Diapositivas.Add(new Diapositiva("Kangchenjunga", "88009 asdas", "Images/Kangchenjunga"));
 Diapositivas.Add(new Diapositiva("Lhotse", "88009 asdas", "Images/Lhotse"));


        Titulo.text = Diapositivas[0].tit;
        Desc.text = Diapositivas[0].desc;
        Foto.sprite = Diapositivas[0].foto;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            if (currentPosition == 0) { return;   }
            currentPosition--;
            Titulo.text = Diapositivas[currentPosition].tit;
            Desc.text = Diapositivas[currentPosition].desc;
            Foto.sprite = Diapositivas[currentPosition].foto;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))   {
            if (currentPosition == Diapositivas.Count-1) { return; }
            currentPosition++;
            Titulo.text = Diapositivas[currentPosition].tit;
            Desc.text = Diapositivas[currentPosition].desc;
            Foto.sprite = Diapositivas[currentPosition].foto;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorizontalBar : MonoBehaviour {
    public Image health;
    float hp, maxHp = 100f;

	// Use this for initialization
	void Start () {
        hp = maxHp;
        health.transform.localScale = new Vector2(0.5f, 1);
       // TakeDamage(13f);
    }
	
	// Update is called once per frame
public	void TakeDamage (float amount) {
        hp = Mathf.Clamp(hp - amount, 0f, maxHp);
        health.transform.localScale = new Vector2(hp / maxHp, 1);
	}
}

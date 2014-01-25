using UnityEngine;
using System.Collections;

public class scale : MonoBehaviour {
	UISprite sprite;
	public float fadeTime = 0.5f;
	// Use this for initialization
	void Start () {
		sprite = GetComponent<UISprite>();
		iTween.ValueTo(gameObject, iTween.Hash("from", 1.0f, "to", 1000.0f*100,"time", fadeTime, "easetype", "linear","onupdate", "scaleImage", "oncomplete","destroyGui"));	

	}
	
	// Update is called once per frame
	void scaleImage () {

		sprite.width+=20;
		sprite.height+=20;
	}
}

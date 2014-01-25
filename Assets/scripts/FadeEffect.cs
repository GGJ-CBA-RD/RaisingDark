using UnityEngine;
using System.Collections;

public class FadeEffect : MonoBehaviour {
	UISprite sprite;
	public float fadeTime = 0.5f;
	// Use this for initialization
	void Start () {
		fadeOut();
	}
	
	// Update is called once per frame

	public void fadeOut()
	{
		iTween.ValueTo(gameObject, iTween.Hash("from", 1.0f, "to", 0.0f,"time", fadeTime, "easetype", "linear","onupdate", "setAlpha", "oncomplete","destroyGui"));	
	}

	void setAlpha(float newAlpha) 
	{
		foreach(Transform child in transform)
		{
			if(child.GetComponent<UISprite>() != null)
			{
				sprite = child.GetComponent<UISprite>();
				sprite.color = new Color(  sprite.color.r, sprite.color.g, sprite.color.b, newAlpha);
			}
		}
	}



}

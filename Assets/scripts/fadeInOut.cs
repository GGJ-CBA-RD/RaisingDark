using UnityEngine;
using System.Collections;

public class fadeInOut : MonoBehaviour {
	UISprite sprite;
	public float fadeTime = 0.5f;
	float t = 0;

	// Use this for initialization
	void Start () {
		//fadeIn();
	}

	void Update()
	{



	}
	
	// Update is called once per frame
	public void fadeIn()
	{
		iTween.ValueTo(gameObject, iTween.Hash("from", 0.0f, "to", 1.0f,"time", fadeTime, "easetype", "linear","onupdate", "setAlpha", "oncomplete","fadeOut"));	
	}

	public void fadeOut()
	{
		iTween.ValueTo(gameObject, iTween.Hash("from", 1.0f, "to", 0.0f,"time", fadeTime, "easetype", "linear","onupdate", "setAlpha", "oncomplete","disable"));	

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

	void disable()
	{
		Invoke("disableObject",0.2f);


	}

	void disableObject()
	{
		gameObject.SetActive(false);
	}
}

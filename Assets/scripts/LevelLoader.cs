using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
	UISprite sprite;
	public float fadeTime = 0.5f;
	public string levelName;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	public void fadeIn()
	{

		iTween.ValueTo(gameObject, iTween.Hash("from", 0.0f, "to", 1.0f,"time", fadeTime, "easetype", "linear","onupdate", "setAlpha", "oncomplete","LoadLevelOnClick"));	
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


	void LoadLevelOnClick()
	{
		Application.LoadLevel(levelName);

	}
}

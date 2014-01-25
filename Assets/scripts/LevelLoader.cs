using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
	UISprite sprite;
	public float fadeTime = 0.5f;
	public string levelName;
	public bool loadOnStart = false;
	// Use this for initialization
	void Start () {
		if(loadOnStart)faidOut();
	}
	
	// Update is called once per frame
	public void fadeIn()
	{

		iTween.ValueTo(gameObject, iTween.Hash("from", 0.0f, "to", 1.0f,"time", fadeTime, "easetype", "linear","onupdate", "setAlpha", "oncomplete","LoadLevelOnClick"));	
	}
	public void faidOut()
	{
		
		iTween.ValueTo(gameObject, iTween.Hash("from", 1.0f, "to", 0.0f,"time", fadeTime, "easetype", "linear","onupdate", "setAlpha", "oncomplete","LoadLevelOnClick"));	
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

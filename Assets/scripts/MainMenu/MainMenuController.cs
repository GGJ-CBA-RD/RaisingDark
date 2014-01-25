using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	public GameObject Play;
	public GameObject Config;
	public GameObject Exit;
	public GameObject modal;
	// Use this for initialization
	void Start () {
		UIEventListener.Get(Play).onClick = onClickPlay;
		UIEventListener.Get(Config).onClick = onClickConfig;
		UIEventListener.Get(Exit).onClick = onClickExit;
	}
	
	// Update is called once per frame
	void onClickPlay (GameObject Go) {
		print("touch");
		modal.SetActive(true);
		modal.GetComponent<LevelLoader>().levelName="habitacion1";
		modal.GetComponent<LevelLoader>().fadeIn();

	}

	void onClickConfig (GameObject Go) {
		
	}

	void onClickExit (GameObject Go) {
		Application.Quit();
	}
}

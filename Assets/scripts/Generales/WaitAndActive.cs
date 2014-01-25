using UnityEngine;
using System.Collections;

public class WaitAndActive : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("load",8);
	}
	
	// Update is called once per frame
	void load () {
		GetComponent<LevelLoader>().enabled=true;
	}
}

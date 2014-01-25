using UnityEngine;
using System.Collections;

public class interruptorController : MonoBehaviour {

	public GameObject interruptor;
	// Use this for initialization
	void Start () {
		UIEventListener.Get(interruptor).onClick += interruptorClick;
	}
	
	// Update is called once per frame
	public void interruptorClick(GameObject Go) {
		print("AAA");
	}
}

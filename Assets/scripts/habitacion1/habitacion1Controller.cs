using UnityEngine;
using System.Collections;

public class habitacion1Controller : MonoBehaviour {

	public GameObject interruptor;
	public GameObject puerta;
	public GameObject Anchor;
	// Use this for initialization
	void Start () {

		UIEventListener.Get(interruptor).onClick += interruptorClick;
	}

	public void interruptorClick(GameObject go) 
	{

		puerta.GetComponent<scale>().enabled = true;
		Anchor.GetComponent<FadeEffect>().enabled = true;
	}
}

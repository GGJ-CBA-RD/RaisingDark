using UnityEngine;
using System.Collections;

public class stage2Controller : MonoBehaviour {
	public GameObject paredesAlt;
	public GameObject interruptor;
	// Use this for initialization
	void Start () {

		UIEventListener.Get(interruptor).onClick += interruptorClick;
	}

	void Update()
	{
		if (AccelerometerManager.itsShaking) 
		{
			paredesAlt.SetActive (true);
			paredesAlt.GetComponent<fadeInOut> ().fadeIn ();
		}
	}
	
	// Update is called once per frame
	public void interruptorClick (GameObject Go) 
	{
		//paredesAlt.SetActive(true);
		//paredesAlt.GetComponent<fadeInOut>().fadeIn();
	}
}

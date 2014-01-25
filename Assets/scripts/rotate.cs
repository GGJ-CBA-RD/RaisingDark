using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	public bool x = false;
	public bool y = false;
	public bool z = false;
	public float speed = -0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(x)transform.Rotate(new Vector3(speed,0,0));
		if(y)transform.Rotate(new Vector3(0,speed,0));
		if(z)transform.Rotate(new Vector3(0,0,speed));
	}
}

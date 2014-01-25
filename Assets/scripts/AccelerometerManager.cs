using UnityEngine;
using System.Collections;

public class AccelerometerManager : MonoBehaviour
{
	public static bool itsShaking;

	float LowPassKernelWidthInSeconds = 1.0f;

	float AccelerometerUpdateInterval = 1.0f / 60.0f;
	
	float LowPassFilterFactor; 
	
	Vector3 lowPassValue = Vector3.zero; // should be initialized with 1st sample
	
	Vector3 phoneAcc;
	
	Vector3 phoneDeltaAcc;

	void Start()
	{
		itsShaking = false;
	}
	
	Vector3 LowPassFilter(Vector3 newSample) 
	{
		lowPassValue = Vector3.Lerp(lowPassValue, newSample, LowPassFilterFactor);
		
		return lowPassValue;
	}
	
	void FixedUpdate () 
	{
		phoneAcc = Input.acceleration;
		
		phoneDeltaAcc = phoneAcc-LowPassFilter(phoneAcc);

		if(Mathf.Abs(phoneDeltaAcc.y) >= 0.9f) 
			itsShaking = true;
		else
			itsShaking = false;
		
	}
}

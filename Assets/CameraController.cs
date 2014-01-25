using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	float actionLimit = 1;
	Vector3 newRotation = Vector3.zero;
	public bool canMove = true;
	void OnEnable(){
		EasyTouch.On_SwipeStart += On_SwipeStart;
		EasyTouch.On_Swipe += On_Swipe;
		EasyTouch.On_SwipeEnd += On_SwipeEnd;		
	}
	
	void OnDisable(){
		//UnsubscribeEvent();
	
	}

	void OnDestroy(){
		//UnsubscribeEvent();
	}


	void On_SwipeStart(Gesture gesture)
	{


	}

	void On_Swipe(Gesture gesture)
	{
		if(canMove){
		
		
			if(gesture.swipeVector.x > actionLimit)
			{
				newRotation = new Vector3(newRotation.x,newRotation.y-90,newRotation.z);
				iTween.RotateTo(gameObject,iTween.Hash("rotation",newRotation,"time",2,"oncomplete","UpdateCanMove"));
				canMove = false;
			}
			else
			{
				if(gesture.swipeVector.x < actionLimit*-1)
				{
					newRotation = new Vector3(newRotation.x,newRotation.y+90,newRotation.z);
					iTween.RotateTo(gameObject,iTween.Hash("rotation",newRotation,"time",2,"oncomplete","UpdateCanMove"));
					canMove = false;
				}

			}
		}
	}

	void On_SwipeEnd(Gesture gesture)
	{


	}

	void UpdateCanMove(){
		canMove = true;

	}
}

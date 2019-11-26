using UnityEngine;
using System.Collections;

public class travel : MonoBehaviour 
{
	public float speed;

	public KeyCode[] travelKey;
	public GameObject[] positionTarget;
	public GameObject[] lookTarget;

	private bool isTraveling=false;
	private int targetIndex;
	float timeElapsed=0.0f;
	float initialDistance;
	void Start ()
	{
	}


	// Update is called once per frame
	void Update () 
	{
		for (int i = 0; i < travelKey.Length; i++) {
			if (Input.GetKeyDown (travelKey[i])) {
				transform.parent = null; //unparent the camera
				isTraveling = true;
				targetIndex = i;
				timeElapsed = 0.0f;
				initialDistance = Vector3.Distance (transform.position, positionTarget [targetIndex].transform.position);

				print ("starting travel to planet: " + targetIndex);
			}
		}

		//other keys here
		//
		//

		if (isTraveling) 
		{
			timeElapsed += Time.deltaTime;

			float travelAmount = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, positionTarget[targetIndex].transform.position, travelAmount);
			//transform.LookAt (lookTarget[targetIndex].transform.position); //snaps 100%
			Quaternion currentQ=transform.rotation;
			Quaternion fullQ = Quaternion.LookRotation (lookTarget [targetIndex].transform.position - transform.position);

			float lookPercentage = 1.0f-Mathf.Clamp (Vector3.Distance (transform.position, positionTarget [targetIndex].transform.position) / initialDistance, 0f, 1f);


			//Smoothing

			Quaternion softQ = Quaternion.Slerp (currentQ, fullQ, lookPercentage);
			transform.rotation = softQ;


			if (transform.position == positionTarget [targetIndex].transform.position) {
				print ("close to our target, stopping travel");
				isTraveling = false;
				transform.parent = positionTarget [targetIndex].transform;

			}
		}
	}
}
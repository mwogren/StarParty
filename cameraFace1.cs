using UnityEngine;
using System.Collections;

public class cameraFace1 : MonoBehaviour 
{
	void Start () {
	}

	void Update () 
	{
		transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
	}
}

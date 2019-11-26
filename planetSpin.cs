using UnityEngine;
using System.Collections;

public class planetSpin : MonoBehaviour 
	{
		public float Speed = 10f;

		void Update ()
		{
			transform.Rotate(Vector3.up, Speed * Time.deltaTime);
			transform.RotateAround(Vector3.zero, Vector3.up, Speed * Time.deltaTime);
		}
	}
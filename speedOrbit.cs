using UnityEngine;
using System.Collections;

public class speedOrbit : MonoBehaviour
{
	public float orbitalSpeed = 1f;
	public float rotation = 1f;

	void Update ()
	{
		transform.Rotate(Vector3.up, rotation * Time.deltaTime);
		transform.RotateAround(Vector3.zero, Vector3.up, orbitalSpeed * Time.deltaTime);
	}
}
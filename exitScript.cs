using UnityEngine;
using System.Collections;

public class exitScript : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKey("escape"))
			Application.Quit();

	}
}

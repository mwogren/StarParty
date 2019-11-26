using UnityEngine;
using System.Collections;

public class getText : MonoBehaviour
{
	public GameObject planetInfo;
	public bool isInfoText;

	void Start () 
	{
		planetInfo.SetActive (false);
	}

	void Update () 
	{
	}

	void OnMouseDown()
	{
		if (Input.GetMouseButton (0))
			isInfoText = !isInfoText;

			if (isInfoText)
			{
				planetInfo.gameObject.SetActive (true);
			}

		else
		{
			planetInfo.gameObject.SetActive (false);
		}
	}
}
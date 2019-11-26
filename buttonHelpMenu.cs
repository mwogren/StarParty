using UnityEngine;
using System.Collections;

public class buttonHelpMenu : MonoBehaviour
{
	public GameObject menuObject;

	// Use this for initialization
	void Start () 
	{
		menuObject.SetActive (false);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey("h"))
			menuObject.gameObject.SetActive (true);

		Debug.Log("left click");

	}
}

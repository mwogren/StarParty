using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour 
{
	public Texture menuTex1;
	public Texture menuTex2;
	public Texture menuTex3;
	public Texture menuTex4;
	public Texture menuTex5;

	private Rect windowRect = new Rect (0, 0, 750, 675);
	private bool showMenu = false;

	void Start()
	{
	}

	void Update()
	{ 
		if (Input.GetKeyDown ("space")) 
		{
			print ("pressed key");
			showMenu = !showMenu;
			print (showMenu);
		}
	}

	void OnGUI () 
	{
		if(showMenu)
			windowRect = GUI.Window (0, windowRect, WindowFunction, "Help Menu");
	}

	void WindowFunction (int windowID) 
	{
		if (!menuTex1) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		if (GUI.Button(new Rect(0, 0, 750, 375), menuTex2))
		Application.LoadLevel("Stage1");

		if (GUI.Button(new Rect(0, 375, 750, 100), menuTex3))
			Application.LoadLevel("welcomeScreen");

		if (GUI.Button(new Rect(0, 475, 750, 100), menuTex4))
			Application.LoadLevel("outdoors");

		if (GUI.Button(new Rect(0, 575, 750, 100), menuTex5))
			Application.LoadLevel("theSolarSystem");
	}

}

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class kiosk1ScreenContent : MonoBehaviour
{
	Texture myTexture;

	void Start () {
		StartCoroutine (GetTextureWeb());
	}

	IEnumerator GetTextureWeb()
	{
		UnityWebRequest www =
			UnityWebRequest.GetTexture ("http://people.duke.edu/~mwo4/kioskScreenSavr.png");
		
		yield return www.Send ();

		if (www.isError) {
			Debug.Log (www.error);
		} else {
			myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
			GetComponent<Renderer> ().material.mainTexture = myTexture;
		}
	}
}
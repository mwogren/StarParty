using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class starChartScreenContent : MonoBehaviour
{
	Texture myTexture;

	void Start () {
		StartCoroutine (GetTextureWeb());
	}

	IEnumerator GetTextureWeb()
	{
		UnityWebRequest www =
			UnityWebRequest.GetTexture ("http://www.telescope.com/assets/images/starcharts/2016-11-starchart_col.png");
		yield return www.Send ();

		if (www.isError) {
			Debug.Log (www.error);
		} else {
			myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
			GetComponent<Renderer> ().material.mainTexture = myTexture;
		}
	}
}
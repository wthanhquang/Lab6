using UnityEngine;
using System.Collections;

public class d : MonoBehaviour {
	
	public float timer;
	public string levelToLoad = "Main";
	
	// Use this for initialization
	void Start () {
		StartCoroutine("DisplayScene");
	}
	
	IEnumerator DisplayScene(){
		yield return new WaitForSeconds( timer );
		Application.LoadLevel (levelToLoad);
	}
}
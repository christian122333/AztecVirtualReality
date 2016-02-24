using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") || Cardboard.SDK.CardboardTriggered) {
			Application.LoadLevel ("triggerAudio");
		}
	
	}
}

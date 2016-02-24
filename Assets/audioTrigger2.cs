using UnityEngine;
using System.Collections;


public class audioTrigger2: MonoBehaviour {

	public AudioClip clip;
	//public AudioClip clip2;
	AudioSource audio;


	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (!AudioIndicator.isPlaying1) {
			audio.Stop();
		}

	}

	void OnTriggerEnter(Collider other){
		if(!AudioIndicator.isPlaying1){
			audio.clip = clip;
			audio.Play ();
			AudioIndicator.isPlaying1 = true;
			//audio.PlayOneShot(clip);
		}
	}

	private void setOtherFalse(){
		AudioIndicator.isPlaying0 = false;
		AudioIndicator.isPlaying2 = false;
		AudioIndicator.isPlaying3 = false;
	}
}

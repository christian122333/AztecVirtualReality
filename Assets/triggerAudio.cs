using UnityEngine;
using System.Collections.Generic;



public class triggerAudio : MonoBehaviour {

	public AudioClip clip;
	public GameObject cube;
	public GameObject cube1;
	AudioSource audio;
	private AudioSource[] allAudioSources;

	private List<AudioSource> list = new List<AudioSource> ();


	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();


	}
	
	// Update is called once per frame
	void Update () {	
			if (Input.GetButton ("Fire1")) {
				StopAllAudio();
			}
	}

	void StopAllAudio(){
		allAudioSources = FindObjectsOfType (typeof(AudioSource)) as AudioSource[];
		foreach (AudioSource audioS in allAudioSources) {
			audioS.Stop ();
		}
	}

	void OnTriggerEnter(Collider other){
		if (!this.audio.isPlaying) {
			StopAllAudio ();
			this.audio.Play ();
		}
			
	}



	


	
}

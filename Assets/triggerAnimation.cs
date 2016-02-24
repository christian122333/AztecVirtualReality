using UnityEngine;
using System.Collections;

public class triggerAnimation : MonoBehaviour {

	public Animator one;
	public Animator two;

	// Use this for initialization
	void Start () {
		one.enabled = false;
		two.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		one.enabled = true;
		two.enabled = true;
	}

	void OnTriggerExit(Collider other)
	{
		one.enabled = false;
		two.enabled = false;
	}
}

using UnityEngine;
using System.Collections;

public class triggerAnimation : MonoBehaviour {

	public Animator an1;
	public Animator an2;
	public Animator an3;
	public Animator an4;
	public Animator an5;
	public Animator an6;
	public Animator an7;
	public Animator an8;
	public Animator an9;
	public Animator an10;
	public Animator an11;


	// Use this for initialization
	void Start () {
		an1.enabled = false;
		an2.enabled = false;
		an3.enabled = false;
		an4.enabled = false;
		an5.enabled = false;
		an6.enabled = false;
		an7.enabled = false;
		an8.enabled = false;
		an9.enabled = false;
		an10.enabled = false;
		an11.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		an1.enabled = true;
		an2.enabled = true;
		an3.enabled = true;
		an4.enabled = true;
		an5.enabled = true;
		an6.enabled = true;
		an7.enabled = true;
		an8.enabled = true;
		an9.enabled = true;
		an10.enabled = true;
		an11.enabled = true;

	}

	void OnTriggerExit(Collider other)
	{
		an1.enabled = false;
		an2.enabled = false;
		an3.enabled = false;
		an4.enabled = false;
		an5.enabled = false;
		an6.enabled = false;
		an7.enabled = false;
		an8.enabled = false;
		an9.enabled = false;
		an10.enabled = false;
		an11.enabled = false;

	}
}

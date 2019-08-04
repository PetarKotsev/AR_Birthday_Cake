using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

[RequireComponent(typeof(AudioSource))]
public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {
 

	public GameObject vb_GO;
	public AudioSource source;
	public AudioClip clip;
	public bool musicPlayed = false;

	// Use this for initialization

	void Start () {

		vb_GO = GameObject.Find ("playButton");
		vb_GO.GetComponent<VirtualButtonAbstractBehaviour>().RegisterEventHandler(this);
		//source = AudioSource.Find ("Music");
		source = GetComponent<AudioSource> ();
	}
	
	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
	{
		Debug.Log ("Button down");
		if (!musicPlayed) {
			source.Play ();
			musicPlayed = true;
		}
	}
	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
	{
		
	}
}

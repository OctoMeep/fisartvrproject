using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class TeleportHome : MonoBehaviour {

	public SteamVR_Action_Boolean homeAction;

	public GameObject home;

	private float downSince = 0f;

	public float delay = 1f;

	private bool down = false;

	public void Update() {
		if (homeAction.GetState(SteamVR_Input_Sources.Any)) {
			if(down){
				if(Time.time - downSince >= delay){
					print("yeet");
					teleport();
					down = false;
				}
			}
			else{
				down = true;
				downSince = Time.time;
			}
		}
		else {
			down = false;
		}
	}
	
	private void teleport(){
		transform.position = home.transform.position;
	}
}

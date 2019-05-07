using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mButton : MonoBehaviour {

	public GameObject r;
	private GameObject p;

	public void Start(){
		p = GameObject.FindWithTag("Player");
	}

	public void pressed(){
		p.transform.position = r.transform.position;
	}
}

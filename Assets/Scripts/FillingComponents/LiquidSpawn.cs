using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidSpawn : MonoBehaviour {

	public GameObject Liquid;

	float count=0;

	private Transform playerRotation;
	// Use this for initialization
	void Start () {

		playerRotation = GetComponentInParent<Transform>();
	}

	// Update is called once per frame
	void Update () {
		count += 1;
		float angle = Vector3.Angle (transform.up, Vector3.up);
		if(angle>=90 && count>=5){
			Instantiate (Liquid, transform.position, playerRotation.rotation);
			count =0;

		}
	}
}
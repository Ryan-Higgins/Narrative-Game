using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour {

	public List<Transform> points;
	Vector3 playerPos;
	float distance;

	// Use this for initialization
	void Start () {
		playerPos = transform.position;
		points [0] = transform;
		points [1] = transform;
	}
	
	// Update is called once per frame
	void Update () {
		distance = 
		if(Input.GetKey(KeyCode.D) && points[0].position == playerPos) {
			playerPos
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour {

	public List<Transform> points;
	int currentPoint;
	Transform targetPoint;
	float speed = 4f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(currentPoint < this.points.Count)
		{
			if(targetPoint == null)
				targetPoint = points[currentPoint];
			Walk();
		}
	}

	void Walk() {
		transform.position = Vector3.MoveTowards(transform.position, targetPoint.position,   speed*Time.deltaTime);

		if (transform.position == targetPoint.position && targetPoint.position == points [0].position && Input.GetKeyDown (KeyCode.D)) {
			targetPoint = points [1];
		} else if (transform.position == targetPoint.position && targetPoint.position == points [1].position && Input.GetKeyDown (KeyCode.A)) {
			targetPoint = points [0];
		} else if (transform.position == targetPoint.position && targetPoint.position == points [0].position && Input.GetKeyDown (KeyCode.S)) {
			targetPoint = points [3];
		} else if (transform.position == targetPoint.position && targetPoint.position == points [3].position && Input.GetKeyDown (KeyCode.W)) {
			targetPoint = points [0];
		} else if (transform.position == targetPoint.position && targetPoint.position == points [1].position && Input.GetKeyDown (KeyCode.S)) {
			targetPoint = points [2];
		} else if (transform.position == targetPoint.position && targetPoint.position == points [2].position && Input.GetKeyDown (KeyCode.W)) {
			targetPoint = points [1];
		} else if (transform.position == targetPoint.position && targetPoint.position == points [2].position && Input.GetKeyDown (KeyCode.A)) {
			targetPoint = points [3];
		} else if (transform.position == targetPoint.position && targetPoint.position == points [3].position && Input.GetKeyDown (KeyCode.D)) {
			targetPoint = points [2];
		}
	}
}

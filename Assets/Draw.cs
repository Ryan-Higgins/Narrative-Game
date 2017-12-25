using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Plane objPlane = new Plane (Camera.main.transform.forward * -1, this.transform.position);

			Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			float rayDistance;
			if(objPlane.Raycast(myRay, out rayDistance)) {
				this.transform.position = myRay.GetPoint(rayDistance);
			}
		}
	}
}

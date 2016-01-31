using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject Target;

    private Vector3 boomDistance;

	// Use this for initialization
	void Start () {

        boomDistance = transform.position - Target.transform.position;

	}
	
	// LateUpdate is called after every other GameObject has processed its Update function
	void LateUpdate () {

        // Follow target at fixed distance
        transform.position = boomDistance + Target.transform.position;

	}
}

using UnityEngine;
using System.Collections;

public class GateController : MonoBehaviour {

    public Vector3 OpenedRotation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Set rotation to opened
    void OpenGate()
    {

        transform.eulerAngles = OpenedRotation;

    }
}

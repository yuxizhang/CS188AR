using UnityEngine;
using System.Collections;

public class CoinBehavior : MonoBehaviour {

    public Vector3 RotationSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(RotationSpeed * Time.deltaTime, Space.World);

	}
}

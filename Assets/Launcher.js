#pragma strict
var missile : Rigidbody;
var timeout : float = 2;

function Update () {

	if (timeout <= 0) {
		Instantiate(missile, transform.position,transform.rotation);
		timeout = 2;
   	} else {
   		timeout -= Time.deltaTime;
   	}
}

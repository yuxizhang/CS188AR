#pragma strict
var missile : Rigidbody;
var timeout : float = 3;
var speed : float = 3;


function Start() {

}

function Update () {

	if (transform.position.x <= -7.8 || transform.position.x >= 7.8)
		speed = - speed;

	transform.Translate(speed * Vector3.right * Time.deltaTime);

	if (timeout <= 0) {
		Instantiate(missile, transform.position,transform.rotation);
		timeout = 3;
   	} else {
   		timeout -= Time.deltaTime;
   	}
}

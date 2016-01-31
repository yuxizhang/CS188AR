#pragma strict
 
var missileVelocity : float = 1;
var turn : float = 20;
var homingMissile : Rigidbody;
var fuseDelay : float;
var missileMod : GameObject;
var SmokePrefab : ParticleSystem;
var missileClip : AudioClip;
var targetPosition : Vector3;
var explosion : GameObject;

private var target : Transform;
 
function Start () {
 
Fire();
 
}
 
function FixedUpdate ()
 
{	

    if(target == null || homingMissile == null)
        return;
 
    homingMissile.velocity = transform.forward * missileVelocity;
    var targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
  	// Debug.Log(target.position.constructor.name);
    homingMissile.MoveRotation(Quaternion.RotateTowards(transform.rotation, targetRotation, turn));
 
}
 
function Fire ()
 
{	
    yield WaitForSeconds (fuseDelay);
//    AudioSource.PlayClipAtPoint(missileClip, transform.position);
 
    var distance = Mathf.Infinity;
 
    for (var go : GameObject in GameObject.FindGameObjectsWithTag("target"))
        {
            var diff = (go.transform.position - transform.position).sqrMagnitude;
 
            if(diff < distance)
            {
                distance = diff;
                target = go.transform;
                targetPosition = target.position;
            }
 
        }
 
}
 
function OnCollisionEnter (theCollision : Collision)
{
 
    //if(theCollision.gameObject.name == "Cube (1)")
    {
        //SmokePrefab.emissionRate = 0.0f;
        Destroy(missileMod.gameObject);


        Destroy(gameObject);

        var newexplosion : GameObject = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);

        //yield WaitForSeconds(3);
        Destroy(newexplosion, 3);

    }
 
}
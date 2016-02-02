#pragma strict

import UnityEngine.UI;
var healthSlider : Slider; 

function OnCollisionEnter (theCollision : Collision)
{
    healthSlider.value -= 10;
}
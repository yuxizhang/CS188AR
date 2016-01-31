using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SkeletonNPC : MonoBehaviour {

    public Text DialogueText;

    public string SayText;

    public Vector3 TextOffset;

    private bool isPlayerNear;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	    if (isPlayerNear)
        {
            DialogueText.transform.position = Camera.main.WorldToScreenPoint(transform.position) + TextOffset;
        }

	}

    // Interact with player
    void OnTalk()
    {

        ChangeText(SayText);
        isPlayerNear = true;

    }

    // Stop interacting with player
    void OnLeave()
    {

        ChangeText("");
        isPlayerNear = false;

    }

    // Change message displayed on screen
    void ChangeText(string message)
    {

        if (DialogueText)
        {
            DialogueText.text = message;
        }

    }
}

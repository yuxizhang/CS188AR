using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SkeletonQuestNPC : MonoBehaviour {

    public PlayerController PlayerControllerRef;
    public int CoinsRequired = 5;

    public GameObject[] Gates;

    public Vector3 TextOffset;

    private bool isPlayerNear;

    public Text DialogueText;

    public string NotSatisfied;
    public string JustSatisfied;
    public string WasSatisfied;

    private bool completed;

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

        isPlayerNear = true;
        if (PlayerControllerRef.GetCoinCount() >= 5)
        {
            if (!completed)
            {
                ChangeText(JustSatisfied);
                
                // Open gates
                foreach (GameObject gate in Gates)
                {
                    gate.BroadcastMessage("OpenGate");
                }

                completed = true;
            }
            else
            {
                ChangeText(WasSatisfied);
            }
        }
        else
        {
            ChangeText(NotSatisfied);
        }

    }

    // Stop interacting with player
    void OnLeave()
    {

        isPlayerNear = false;
        ChangeText("");

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

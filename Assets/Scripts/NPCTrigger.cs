using UnityEngine;
using System.Collections;

public class NPCTrigger : MonoBehaviour {

    public GameObject Source;
    public GameObject NPC;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Called when someone enters our trigger box
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject == Source)
        {
            if (NPC)
            {
                NPC.BroadcastMessage("OnTalk");
            }
        }

    }

    // Called when someone enters our trigger box
    void OnTriggerExit(Collider col)
    {

        if (col.gameObject == Source)
        {
            if (NPC)
            {
                NPC.BroadcastMessage("OnLeave");
            }
        }

    }
}

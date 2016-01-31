using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Text CoinCountText;

    private int coins;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Called when we first enter another trigger box
    void OnTriggerEnter(Collider col)
    {

        // If we picked up a coin
        if (col.gameObject.CompareTag("Coin"))
        {
            // Deactivate coin and increment our coin count
            col.gameObject.SetActive(false);
            coins++;
            UpdateCoinCount();
        }

    }

    // Update coin text on UI
    void UpdateCoinCount()
    {
        
        if (CoinCountText)
        {
            CoinCountText.text = coins.ToString();
        }

    }

    // Returns the number of coins we have collected
    public int GetCoinCount()
    {
        return coins;
    }
}

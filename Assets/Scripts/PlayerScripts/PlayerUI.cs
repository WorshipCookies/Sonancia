using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

    private bool playerAtObjective;
    private Text endText;

	// Use this for initialization
	void Start () {

        playerAtObjective = false;
        endText = this.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>();
        endText.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (playerAtObjective && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Player at the Objective and Pressed E!");
            Application.Quit();
        }
	}

    public void setPlayerObjective(bool isAtObjective)
    {
        playerAtObjective = isAtObjective;
        endText.enabled = playerAtObjective;
    }

}

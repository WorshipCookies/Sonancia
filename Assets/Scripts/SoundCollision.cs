using UnityEngine;
using System.Collections;

public class SoundCollision : MonoBehaviour {

    private bool notPlayed = true;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Trigger!!!!!!!! + " + col.gameObject.name);
        if (col.gameObject.name == "FPSPlayer" && notPlayed)
        {
            AudioSource aS = GetComponent<AudioSource>();
            aS.PlayOneShot(aS.clip);
            notPlayed = false;
        }
    }
}

using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    private int playerHealth;
    private bool isDead;

    private PlayerRespawn spawn;

    private static int MAX_HEALTH = 3;
    private static int DEFAULT_DMG = 1;

    void Awake()
    {
        playerHealth = MAX_HEALTH;
        isDead = false;
        spawn = GetComponent<PlayerRespawn>();
    }

    void Update()
    {
        if (isDead)
        {
            Debug.Log("Player Has Died!");
            spawn.respawnPlayerStart();
            refillHealth();
        }
    }

    public void takeDamage(int dmg)
    {
        playerHealth -= dmg;

        if(playerHealth <= 0)
        {
            isDead = true;
        }

        Debug.Log("Current Health == " + playerHealth);
    }

    public void takeDamage()
    {
        playerHealth -= DEFAULT_DMG;
        if (playerHealth <= 0)
        {
            isDead = true;
        }

        Debug.Log("Current Health == " + playerHealth);
    }

    public void regainHealth(int health)
    {
        int newHealth = playerHealth + health;
        playerHealth = Mathf.Min(MAX_HEALTH, newHealth);
    }
	
    public void regainHealth()
    {
        int newHealth = playerHealth + DEFAULT_DMG;
        playerHealth = Mathf.Min(MAX_HEALTH, newHealth);
    }

    public bool playerIsDead()
    {
        return isDead;
    }

    public void refillHealth()
    {
        playerHealth = MAX_HEALTH;
        isDead = false;
    }
}

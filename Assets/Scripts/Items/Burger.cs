using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger : MonoBehaviour, ICollectible
{
    public int healthToRestore;

    public void Collect()
    {
        PlayerStats player = FindObjectOfType<PlayerStats>();

        player.RestoreHealth(healthToRestore);

        Destroy(gameObject);
    }
}

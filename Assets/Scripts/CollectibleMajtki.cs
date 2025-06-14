using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleMajtki : MonoBehaviour
{
    public float healing = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        //TODO sent info to player
        Inventory playerInventory = null;
        playerInventory = collision.gameObject.GetComponent<Inventory>();

        if (playerInventory == null) return;

        playerInventory.Collect();

        Player_Health healthPlayer = collision.gameObject.GetComponent<Player_Health>();

        if (healthPlayer == null)
        {
            return;
        }

        healthPlayer.TakeDamage(-healing);

        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleMajtki : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        //TODO sent info to player
        Inventory playerInventory = null;
        playerInventory = collision.gameObject.GetComponent<Inventory>();

        //playerInventory

        Destroy(gameObject);
    }
}

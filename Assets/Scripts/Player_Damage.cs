using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Damage : MonoBehaviour
{

    public float damage = 40;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        Player_Health healthPlayer = collision.gameObject.GetComponent<Player_Health>();

        if(healthPlayer == null)
        {
            return;
        }

        healthPlayer.TakeDamage(damage);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{
    [SerializeField] private float maxHealthPlayer = 100;
    [SerializeField] private float healthPlayer = 100;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public bool isDead = false;
    public void TakeDamage(float damage)
    {
        healthPlayer = healthPlayer - damage;
        if(healthPlayer < 0)
        {
            healthPlayer = 0;
        }
        if(healthPlayer > maxHealthPlayer)
        {
            healthPlayer = maxHealthPlayer;
        }
        if(healthPlayer == 0)
        {
            isDead = true;
            anim.SetTrigger("IsDead");
        }
    }
}

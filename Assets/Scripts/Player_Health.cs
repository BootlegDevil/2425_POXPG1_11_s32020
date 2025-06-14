using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    [SerializeField] private float maxHealthPlayer = 100;
    [SerializeField] private float healthPlayer = 100;
    public Animator anim;
    public TextMeshProUGUI textHealthPlayer;

    private void Start()
    {
        anim = GetComponent<Animator>();
        textHealthPlayer.text = healthPlayer.ToString();
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
            Invoke(nameof(ReloadScene), 2);
        }
        textHealthPlayer.text = healthPlayer.ToString();
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

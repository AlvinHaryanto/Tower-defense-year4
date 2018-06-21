using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;
    [HideInInspector]
    public float speed;

    public int worth = 50;

    private bool isDead = false;
    public float health = 100;

    void Start()
    {
        speed = startSpeed;

    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0 && !isDead)
        {
            Die();
        }
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }

    void Die()
    {

        isDead = true;
        PlayerStats.Money += worth;
        Destroy(gameObject);

        WaveSpawner.EnemiesAlive--;
    }



}


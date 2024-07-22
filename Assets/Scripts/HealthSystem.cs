using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;

    public GameManagerScript gameManager;

    private bool isDead;

    //internal void Health(float damge)
    //{
    //    throw new NotImplementedException();
    //}

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health/ maxHealth, 0.0f, 1.0f);

        if(health <= 0 && !isDead)
        {
            isDead = true;
            gameManager.gameOver();
            Debug.Log("Dead");
        }
    }
}

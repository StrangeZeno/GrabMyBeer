using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //AudioManager audioManager;

    Vector2 startPos;
    //SpriteRenderer spriteRenderer;
    Rigidbody2D playerRb;

    private void Awake()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        playerRb = GetComponent<Rigidbody2D>();
        //audioManager = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioManager>();
    }

    private void Start()
    {
        startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();
            //audioManager.PlaySFX(audioManager.deathSound);
        }
    }

    void Die()
    {
        StartCoroutine(Respawn(0.5f));
    }

    //void Respawn()
    //{
    //    transform.position = startPos;
    //}

    IEnumerator Respawn(float duration)
    {
        playerRb.simulated = false;
        playerRb.velocity = new Vector2(0, 0);
        transform.localScale = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
        transform.localScale = new Vector3(3, 3, 0.5f);
        playerRb.simulated = true;

        //spriteRenderer.enabled = true;
    }
}

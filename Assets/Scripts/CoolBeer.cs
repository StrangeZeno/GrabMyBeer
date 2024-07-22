using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolBeer : MonoBehaviour
{
    HealthSystem beerTemperature;

    public float chillBeer = 25f;

    void Awake()
    {
        beerTemperature = FindAnyObjectByType<HealthSystem>();    
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.gameObject.CompareTag("Goal")))
        {


            if (beerTemperature.health < beerTemperature.maxHealth)
            {
                Destroy(gameObject);
                beerTemperature.health = beerTemperature.maxHealth + chillBeer;
            }
        }
    }
}

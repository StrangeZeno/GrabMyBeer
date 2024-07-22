using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<WarmBeer>() != null)
        {
            other.GetComponent<WarmBeer>().GettingWarm(5);
        }
    }
}

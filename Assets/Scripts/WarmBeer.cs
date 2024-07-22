using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarmBeer : MonoBehaviour
{
    private HealthSystem healthS;

    public List<int> heatTickTimers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        healthS = GetComponent<HealthSystem>();
    }
    
    public void GettingWarm(int ticks)
    {
        if (heatTickTimers.Count <= 0)
        {
            heatTickTimers.Add(ticks);
            StartCoroutine(Heat());
        }
        else
        {
            heatTickTimers.Add(ticks);
        }
    }

    IEnumerator Heat()
    {
        while (heatTickTimers.Count > 0)
        {
            for (int i = 0; i < heatTickTimers.Count; i++)
            {
                heatTickTimers[i]--;
            }
            healthS.health -= 1;
            yield return new WaitForSeconds(1f);
        }
    }
}

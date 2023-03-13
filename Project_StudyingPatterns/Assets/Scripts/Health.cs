using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float fullHealth = 100f;
    [SerializeField] float drainPerSecond = 2f;

    float currentHealth = 0;

    private void Awake()
    {
        resetHealth();
        StartCoroutine(healthDrain());
    }

    public void resetHealth()
    {
        currentHealth = fullHealth;
    }
    public float getHealth()
    {
        return currentHealth;
    }

    IEnumerator healthDrain()
    {
        while(currentHealth>0)
        {
            currentHealth -= drainPerSecond;
            yield return new WaitForSeconds(2f);
        }
    }

}

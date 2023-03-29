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

    //Why do we do this onEnable not in Start because the object may be disabled when the game starts.
    private void OnEnable()
    {
        GetComponent<Level>().onlevelUpAction += resetHealth; //listener is like a observer
    }
    private void OnDisable()
    {
        GetComponent<Level>().onlevelUpAction -= resetHealth; //listener is like a observer  
    }

    private void resetHealth()
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

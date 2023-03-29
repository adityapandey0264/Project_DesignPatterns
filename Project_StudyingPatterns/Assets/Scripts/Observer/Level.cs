using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] int pointPerLevel = 200;
    [SerializeField] UnityEvent OnLevelUp;
    int experiencePoints = 0;

    public event Action onlevelUpAction;

    IEnumerator Start()
    {
        while(true)
        {
            yield return new WaitForSeconds(2f);
            GainExperience(100);
        }
    }

    public void GainExperience(int points)
    {
        int level = GetLevel();
        experiencePoints += points;
        if (GetLevel() > level)
        {
            if(onlevelUpAction!=null)
            {
                onlevelUpAction();
            }
        }

    }
    public int GetExperience()
    {
        return experiencePoints;
    }
    public int GetLevel()
    {
        return experiencePoints / pointPerLevel;
    }

}

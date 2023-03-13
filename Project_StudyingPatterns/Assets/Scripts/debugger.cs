using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugger : MonoBehaviour
{
     IEnumerator Start()
    {
        Health health = GetComponent<Health>();
        Level level = GetComponent<Level>();
        while(true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log($"Exp:{level.GetExperience()},Level:{level.GetLevel()},Health:{health.getHealth()}");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantObjectSpawner : MonoBehaviour
{
    [SerializeField] GameObject persistantObjectPrefab = null;
    
    //PRIVATE STATE
    static bool hasSpawned = false;

    private void Awake()
    {
        if(hasSpawned)
        {
          return;
        }
        else
        {
            spawnPersistantObjects();
            hasSpawned = true;
        }
    }

    private void spawnPersistantObjects()
    {
        GameObject persistantObject = Instantiate(persistantObjectPrefab);
        DontDestroyOnLoad(persistantObject);
    }
}

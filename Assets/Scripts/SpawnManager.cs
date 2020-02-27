using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ICSB.SpawnManager
{


public class SpawnManager : MonoBehaviour
{
    // The GameObject to instantiate.
    //public EnemySheet enemySheetRaw;
    public GameObject entityToSpawn;
    public SpawnManagerScriptableObject spawnManagerValues;
    //public string[] charSheets;
    [SerializeField]
    public List<GameObject> spawnedEnemiesList;
    public static event Action OnEnemiesSpawned;
    //public int spawnedEnemiesCount;
    //public UnityEvent enemiesSpawned;
    //public GetSpawnedEnemies battleScreen;

    //public string enemyName;
    //protected BattleManager battle;


    // This will be appended to the name of the created entities and increment when each is created.
    
    private void Awake()
    {
        SpawnEntities(); 
    }

    void SpawnEntities()
    {
        int _instanceNumber = 0;
        int currentSpawnPointIndex = 0;
        spawnedEnemiesList = new List<GameObject>();
        //entityToSpawn = spawnManagerValues.prefabName;
        
        for (int i = 0; i < spawnManagerValues.numberOfPrefabsToCreate; i+=1)
        {
            // Creates an instance of the prefab at the current spawn point.
            GameObject currentEntity = Instantiate(entityToSpawn, spawnManagerValues.spawnPoints[currentSpawnPointIndex], Quaternion.identity);

            
            // Sets the name of the instantiated entity to be the string defined in the ScriptableObject and then appends it with a unique number. 
            currentEntity.name = spawnManagerValues.prefabName + _instanceNumber;
            

            // Moves to the next spawn point index. If it goes out of range, it wraps back to the start.
            currentSpawnPointIndex = (currentSpawnPointIndex + 1) % spawnManagerValues.spawnPoints.Length;
            _instanceNumber += 1;
            spawnedEnemiesList.Add(currentEntity);        
            Debug.Log("Spawn manager - Spawned Enemies" + i + ":" + " " + spawnedEnemiesList[i].name.ToString());
        }
        if (spawnedEnemiesList.Count == spawnManagerValues.numberOfPrefabsToCreate)
        {
            OnEnemiesSpawned?.Invoke();
            Debug.Log("Event Called");
            
        }
    }
    
}
}

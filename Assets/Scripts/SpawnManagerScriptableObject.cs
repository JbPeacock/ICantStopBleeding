
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ICSB.SpawnManager
{

[Serializable] [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManager", order = 1)]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public string prefabName;

    public int numberOfPrefabsToCreate;
    //public int minREnem = 0;
    //public int maxREnem = 8;

    //public List<object> Enemies = new List<object>();

    /*public List<object> GetList()
    {
        return Enemies;
    }*/
  
    public Vector3[] spawnPoints;

    

}
}

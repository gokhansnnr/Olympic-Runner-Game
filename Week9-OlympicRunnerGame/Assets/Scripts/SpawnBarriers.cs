using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBarriers : MonoBehaviour
{
    //Spawn: 35 50  //Cord X: -2f 2f | Cord Z:
    public float minXCord, maxXCord, minZCord, maxZCord;
    public float spawnCount; //Random.Range(35, 50);
    public GameObject barrier;
    

    void SpawnBarrier()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(minXCord, maxXCord), 0.0f, Random.Range(minZCord, maxZCord));
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(barrier, spawnPosition, spawnRotation);
        }
    }
    
    void Start()
    {
        SpawnBarrier();
    }

}

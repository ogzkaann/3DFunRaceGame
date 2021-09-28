using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyAi;
    int xAxis = -6;
    int zAxis = -3;

    void Start()
    {
        for(int z = 0; z < 7; z+=6)
        {
            for(int x = 0; x < 13; x += 3)
                Instantiate(enemyAi, new Vector3(xAxis + x, 0, zAxis + z), Quaternion.identity);
        }
        xAxis = -6;
        zAxis = -3;
    }
}

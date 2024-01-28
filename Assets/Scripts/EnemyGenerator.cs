using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnTime = 1;
    public float spawnRadius = 10;

    float lastEnemyTime = 0;

    void GeneratorEnemy()
    {
        Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
        GameObject.Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Time.time = lastEnemyTime > spawnTime)
        {
            GeneratorEnemy();
            lastEnemyTime = Time.time;
        }*/
    }
}

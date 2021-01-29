using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    /* 
     * Doesnt this look GOOD
     */
    public  GameObject[] enemyList;
    public  float Lbound     = -8.5f;
    public  float Rbound     = 8.5f;
    private float xSpawnPos  = 0;
    private float ySpawnPos  = 6.5f;
    private float zSpawnPos  = 0;
    private int   enemyIndex = 0;

    public float spawnRate = 2f;
    public float timeSinceSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn > spawnRate)
        {
            timeSinceSpawn = 0f;
            int enemyIndex = Random.Range(0, enemyList.Length);
            xSpawnPos = Random.Range(Lbound, Rbound);

            Instantiate(enemyList[enemyIndex], new Vector3(xSpawnPos, ySpawnPos, zSpawnPos),
            enemyList[enemyIndex].transform.rotation);
        }
    }
}

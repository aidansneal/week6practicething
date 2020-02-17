using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipeSetPrefab;
    public float pipeSpawnTime;
    public Transform spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipeSet", 0, pipeSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnPipeSet()
    {
        Instantiate(pipeSetPrefab, spawnPosition.position, Quaternion.identity);
    }


}




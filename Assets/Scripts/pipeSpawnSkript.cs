using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnSkript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2;
    public float heightOffset = 2;
    private float spawnTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer >= spawnRate)
        {
            spawnPipe();
            spawnTimer = 0;
        }
        spawnTimer += Time.deltaTime;
    }

    void spawnPipe()
    {   
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;


        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),transform.position.z), transform.rotation);
    }
}

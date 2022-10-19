using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    private float timeUntilNextSpawn = 0.0f;
    public float timeBetweenSpawns = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilNextSpawn -= Time.deltaTime;
        if (timeUntilNextSpawn <= 0)
        {
            spawnPipe();
        }
    }

    void spawnPipe()
    {
        GameObject newpipe = Instantiate<GameObject>(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-3, 3), 0);
        timeUntilNextSpawn = timeBetweenSpawns;
    }
}

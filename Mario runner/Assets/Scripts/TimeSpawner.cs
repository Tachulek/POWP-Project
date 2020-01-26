using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpawner : MonoBehaviour
{

    public GameObject spawnee;
    public ObstacleFactory factory;
    public GameObject basicObstacleRef;
    public GameObject roundObstacleRef;

    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;


    // Start is called before the first frame update
    void Start()
    {
        factory = new ObstacleFactory();
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnObject()
    {
        float figureShape = Random.Range(0.0f,1.0f);

        if(figureShape > 0.5f)
        {
            factory.setPrefab(basicObstacleRef);
        }
        else
        {
            factory.setPrefab(roundObstacleRef);
        }

        var inst = factory.GetNewInstance();
        inst.transform.position = transform.position + new Vector3(0, Random.Range(-1.0f,1.0f), 0);
        //Instantiate(spawnee, transform.position + new Vector3(0, Random.Range(-1f,1f), 0), transform.rotation);

        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}

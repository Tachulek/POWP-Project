using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFactory : MonoBehaviour 
{

    public GameObject prefab;


    public void setPrefab(GameObject obj)
    {
        prefab = obj;
    }

    public GameObject GetNewInstance()
    {
        return Instantiate(prefab);
    }
}

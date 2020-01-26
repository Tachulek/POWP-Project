using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkPlayerDecorator : MonoBehaviour
{

    public GameObject basePlayer;
    // Start is called before the first frame update
    void Start()
    {
        basePlayer = Instantiate(basePlayer,transform.position,transform.rotation);
        basePlayer.transform.SetParent(this.transform);
        var cubeRenderer = basePlayer.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.red);
    }
  

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Spawn_down : MonoBehaviour
{


    public GameObject Pipe;
    public float spawnrate = 1f;
    public float minheight = -2f;
    public float maxheight = 2f;
    public GameObject bird;
   

   
    // Start is called before the first frame update 

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawner), spawnrate, spawnrate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawner));
    }
    private void Spawner()
    {
        GameObject pipes = Instantiate(Pipe, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minheight, maxheight);
        
      
    }
  
}

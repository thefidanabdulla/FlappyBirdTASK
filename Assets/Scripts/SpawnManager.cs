using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    public float delayTime;
    public float time;

    void Start()
    {
        InvokeRepeating("SpawnPipe", time, delayTime);   
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnPipe()
    {
        float randomY = Random.Range(-3, 2);
        Instantiate(pipePrefab, new Vector3(4, randomY, 0), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] spawnObjects; // set these in the Inspector
    public float minTime = 3f;
    public float maxTime = 12f;

    void Start()
    {
        StartCoroutine(SpawnRandomObject());
    }

    IEnumerator SpawnRandomObject()
    {
        while (true) // repeat forever
        {
            // wait for a random interval
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));

            // choose a random index
            int index = Random.Range(0, spawnObjects.Length);

            // instantiate a copy of the prefab
            GameObject spawnObject = Instantiate(spawnObjects[index], transform.position, Quaternion.identity);

            // (optional) parent the new object under this one
            // spawnObject.transform.parent = transform;
        }
    }
}
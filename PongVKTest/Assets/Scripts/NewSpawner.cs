using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    float RandY;
    Vector2 whereToSpawn;
    [SerializeField]
    private float spawnRate = 2f;
    float nextSpawn = 0.0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandY = Random.Range(4.47f, -4.11f);
            whereToSpawn = new Vector2(transform.position.x, RandY);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }

    }
}

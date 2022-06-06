using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBlock : MonoBehaviour
{
    public GameObject presentPrefab;
    Vector2 presentSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("PressurePlate"))
        {
            Instantiate(presentPrefab, GenerateRandomSpawnPoint(), Quaternion.identity);
            Destroy(gameObject);
        }
    }

    Vector2 GenerateRandomSpawnPoint()
    {
        float randX = Random.Range(-30, 4);
        float randY = Random.Range(-5, -20);
        presentSpawn = new Vector2(randX, randY);
        return presentSpawn;
    }
}

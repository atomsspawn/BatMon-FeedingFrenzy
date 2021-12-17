using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFoodSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] foodPrefabs;

    public float maxTime = 1;
    private float timer = 0;
    //public GameObject[] Collectibles;
    public float height;
    public float timetolive = 5;

    public GameObject ceiling;
    public GameObject ground;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime  && foodPrefabs.Length > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int randFood = Random.Range(0, foodPrefabs.Length);        //generates a random number between 0 and the number of foodPrefabs
                int randSpawnPoint = Random.Range(0, spawnPoints.Length);

                GameObject newCollectable = Instantiate(foodPrefabs[randFood], spawnPoints[randSpawnPoint].position, transform.rotation);

                Destroy(newCollectable, timetolive);

                timer = 0;
            }
        }
        timer += Time.deltaTime;
    }



}

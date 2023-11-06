using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class FallingBall : MonoBehaviour
{

    private float spawnRangeX1 = -17.5f;
    private float spawnRangeX2 = 4.5f;
    private float spawnPosY = 26f;

    [SerializeField] private float speed;

    [SerializeField] private GameObject[] ballsArray;
    private int ballsIndex;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;

    private void Start()
    {

        InvokeRepeating("SpawnRandomBalls",
            startDelay,
            spawnInterval);

    }

    void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    private void SpawnRandomBalls()
    {

        ballsIndex = Random.Range(0, ballsArray.Length);

        Instantiate(ballsArray[ballsIndex],
            RandomSpawnPos(),
            Quaternion.identity);

    }

    private Vector3 RandomSpawnPos()
    {

        float randomX = Random.Range(-spawnRangeX1, spawnRangeX2);

        return new Vector3(randomX, spawnPosY, -5);
    }

}

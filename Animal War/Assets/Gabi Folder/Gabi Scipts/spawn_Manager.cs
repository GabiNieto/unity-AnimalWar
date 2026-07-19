using System.Collections;
using UnityEngine;

public class spawn_Manager : MonoBehaviour
{
    public GameObject animalBunny;
    public GameObject animalDeer;
    public GameObject animalTiger;
    public Transform spawnPoint;

    public float waveInterval = 20f;

    private float tigerSpawnTime = 0f;
    private float bunnySpawnTime = 0f;
    private float deerSpawnTime = 0f;

    void Start() //Start it up
    {
        StartCoroutine(WaveLoop());
    }

    IEnumerator WaveLoop() //Where the magic Happen
    {
        yield return StartCoroutine(Wave1());
        yield return  new WaitForSeconds(waveInterval);
        yield return StartCoroutine(Wave1());
    }

    IEnumerator Wave1()
    {
        for ( int i = 0; i < 5; i++)
        {
            bunnySpawnTime = 1;
            yield return StartCoroutine(SpawnBunny());
        }
    }


    IEnumerator SpawnTiger()
    {
        yield return new WaitForSeconds(tigerSpawnTime);
        Instantiate(animalTiger, spawnPoint.position, Quaternion.identity);
    }

    IEnumerator SpawnBunny()
    {
        yield return new WaitForSeconds(bunnySpawnTime);
        Instantiate(animalBunny, spawnPoint.position, Quaternion.identity);
    }

    IEnumerator SpawnDeer()
    {
        yield return new WaitForSeconds(deerSpawnTime);
        Instantiate(animalDeer, spawnPoint.position, Quaternion.identity);
    }
}

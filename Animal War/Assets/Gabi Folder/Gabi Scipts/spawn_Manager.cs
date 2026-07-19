using System.Collections;
using UnityEngine;

public class spawn_Manager : MonoBehaviour
{
    public GameObject animalBunny;
    public GameObject animalDeer;
    public GameObject animalTiger;
    public GameObject animalSUPERMONKEY;
    public Transform spawnPoint;

    public float waveInterval = 10f;

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
        yield return StartCoroutine(Wave2());
        yield return new WaitForSeconds(waveInterval);
        yield return StartCoroutine(Wave3());
        yield return new WaitForSeconds(waveInterval);
        yield return StartCoroutine(Wave4());
        yield return new WaitForSeconds(waveInterval);
        yield return StartCoroutine(Wave5());
        yield return new WaitForSeconds(waveInterval);
    }

    IEnumerator Wave1()
    {
        for ( int i = 0; i < 22; i++)
        {
            bunnySpawnTime = 2;
            yield return StartCoroutine(SpawnBunny());
        }
    }

    IEnumerator Wave2()
    {
        for (int i = 0; i < 3; i++)
        {
            bunnySpawnTime = 2;
            yield return StartCoroutine(SpawnBunny());
        }
        deerSpawnTime = 2.5f;
        yield return StartCoroutine(SpawnDeer());
    }


    IEnumerator Wave3()
    {
        for (int i = 0; i < 3; i++)
        {
            bunnySpawnTime = 2;
            deerSpawnTime = 2f;
            yield return StartCoroutine(SpawnBunny());
            yield return StartCoroutine(SpawnDeer());
        }
    }


    IEnumerator Wave4()
    {
        for (int i = 0; i < 3; i++)
        {
            bunnySpawnTime = 2;
            yield return StartCoroutine(SpawnBunny());
        }
        tigerSpawnTime = 1f;
        yield return StartCoroutine(SpawnTiger());
    }


    IEnumerator Wave5()
    {
        deerSpawnTime = 2f;
        yield return StartCoroutine(SpawnDeer());
        yield return StartCoroutine(SpawnDeer());
        for (int i = 0; i < 2; i++)
        {
            tigerSpawnTime = 2;
            yield return StartCoroutine(SpawnTiger());
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

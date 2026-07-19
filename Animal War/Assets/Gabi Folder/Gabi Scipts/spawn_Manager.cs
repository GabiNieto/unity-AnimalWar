using System.Collections;
using UnityEngine;

public class spawn_Manager : MonoBehaviour
{
    public GameObject animalBunny;
    public GameObject animalDeer;
    public GameObject animalTiger;
    public GameObject animalMonkey;
    public GameObject animalElephant;
    public GameObject animalCatipiller;
    public Transform spawnPoint;

    public float waveInterval = 10f;

    private float tigerSpawnTime = 0f;
    private float bunnySpawnTime = 0f;
    private float deerSpawnTime = 0f;
    private float monkeySpawnTime = 0f;
    private float elephantSpawnTime = 0f;
    private float catipillerSpawnTime = 0f;

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
        yield return StartCoroutine(Wave6());
        yield return new WaitForSeconds(waveInterval);
        yield return StartCoroutine(Wave7());
        yield return new WaitForSeconds(waveInterval);
        yield return StartCoroutine(Wave8());
        yield return new WaitForSeconds(waveInterval);
        yield return StartCoroutine(Wave9());
        yield return new WaitForSeconds(waveInterval);
        yield return StartCoroutine(Wave10());
        yield return new WaitForSeconds(waveInterval);
    }

    IEnumerator Wave1()
    {
        for ( int i = 0; i < 5; i++)
        {
            bunnySpawnTime = 1;
            yield return StartCoroutine(SpawnBunny());
        }
    }

    IEnumerator Wave2()
    {
        for (int i = 0; i < 3; i++)
        {
            bunnySpawnTime = 1;
            yield return StartCoroutine(SpawnBunny());
        }
        deerSpawnTime = 1;
        yield return StartCoroutine(SpawnDeer());
    }


    IEnumerator Wave3()
    {
        for (int i = 0; i < 3; i++)
        {
            bunnySpawnTime = 1;
            deerSpawnTime = 1;
            yield return StartCoroutine(SpawnBunny());
            yield return StartCoroutine(SpawnDeer());
        }
    }


    IEnumerator Wave4()
    {
        for (int i = 0; i < 3; i++)
        {
            bunnySpawnTime = 1;
            yield return StartCoroutine(SpawnBunny());
        }
        tigerSpawnTime = 1f;
        yield return StartCoroutine(SpawnTiger());
    }


    IEnumerator Wave5()
    {
        deerSpawnTime = 1f;
        yield return StartCoroutine(SpawnDeer());
        yield return StartCoroutine(SpawnDeer());
        for (int i = 0; i < 2; i++)
        {
            tigerSpawnTime = 2;
            yield return StartCoroutine(SpawnTiger());
        }
    }

    IEnumerator Wave6()
    {
        monkeySpawnTime = 1f;
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        elephantSpawnTime = 1;
        yield return StartCoroutine(SpawnElephant());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        tigerSpawnTime = 2;
        yield return StartCoroutine(SpawnTiger());
    }

    IEnumerator Wave7()
    {
        tigerSpawnTime = 2;
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        elephantSpawnTime = 1;
        yield return StartCoroutine(SpawnElephant());
        yield return StartCoroutine(SpawnElephant());
        yield return StartCoroutine(SpawnTiger());
    }

    IEnumerator Wave8()
    {
        catipillerSpawnTime = 1f;
        yield return StartCoroutine(SpawnCatipiller());
        yield return StartCoroutine(SpawnCatipiller());
        monkeySpawnTime = 1f;
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        tigerSpawnTime = 2;
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        catipillerSpawnTime = 1f;
        yield return StartCoroutine(SpawnCatipiller());
        yield return StartCoroutine(SpawnCatipiller());
        monkeySpawnTime = 1f;
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        tigerSpawnTime = 2;
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());


    }

    IEnumerator Wave9()
    {
        catipillerSpawnTime = 1f;
        yield return StartCoroutine(SpawnCatipiller());
        yield return StartCoroutine(SpawnCatipiller());
        tigerSpawnTime = 0.5f;
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        catipillerSpawnTime = 1f;
        yield return StartCoroutine(SpawnCatipiller());
        yield return StartCoroutine(SpawnCatipiller());
    }

    IEnumerator Wave10()
    {
        elephantSpawnTime = 0.5f;
        yield return StartCoroutine(SpawnElephant());
        yield return StartCoroutine(SpawnElephant());
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnElephant());
        tigerSpawnTime = 0.5f;
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnTiger());
        yield return StartCoroutine(SpawnElephant());
        yield return StartCoroutine(SpawnTiger());
        monkeySpawnTime = 0.25f;
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());
        yield return StartCoroutine(SpawnMonkey());

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

    IEnumerator SpawnMonkey()
    {
        yield return new WaitForSeconds(monkeySpawnTime);
        Instantiate(animalMonkey, spawnPoint.position, Quaternion.identity);
    }

    IEnumerator SpawnElephant()
    {
        yield return new WaitForSeconds(elephantSpawnTime);
        Instantiate(animalElephant, spawnPoint.position, Quaternion.identity);
    }

    IEnumerator SpawnCatipiller()
    {
        yield return new WaitForSeconds(catipillerSpawnTime);
        Instantiate(animalCatipiller, spawnPoint.position, Quaternion.identity);
    }
}

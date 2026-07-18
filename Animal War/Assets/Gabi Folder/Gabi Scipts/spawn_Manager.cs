using UnityEngine;

public class spawn_Manager : MonoBehaviour
{
    public GameObject animalBunny;
    public Transform spawnPoint;
    public float spawnTime; //FOR TEST

    private float timerl; //FOR TEST



    // Update is called once per frame
    void Update()
    {
        timerl += Time.deltaTime;

        if(timerl >= spawnTime)
        {
            SpawnBunny();
            timerl = 0;
        }
    }

    void SpawnBunny()
    {
        Instantiate(animalBunny, spawnPoint.position, Quaternion.identity);
    }
}

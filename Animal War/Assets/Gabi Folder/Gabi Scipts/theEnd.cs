using UnityEngine;

public class theEnd : MonoBehaviour
{


    private game_Manager manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = FindAnyObjectByType<game_Manager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            manager.takeDamage();
        }
    }
}

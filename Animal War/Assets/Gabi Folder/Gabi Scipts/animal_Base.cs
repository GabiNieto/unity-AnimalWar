using System.Collections;
using UnityEngine;

public class animal_Base : MonoBehaviour
{


    public float maxHealth = 10f;
    public float currentHealth;
    public float speed = 2.0f;

    public Vector3 startScale = Vector3.one;
    public Vector3 endScale = new Vector3(3f, 3f, 3f);



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        transform.localScale = startScale;

        StartCoroutine(TestDamage()); //FOR TESTING PURPOSE
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        // Scale based on health
        float t = 1f - (currentHealth / maxHealth);
        transform.localScale = Vector3.Lerp(startScale, endScale, t);

        if (currentHealth <= 0)
        {
            StartCoroutine(Die());
        }
    }


    IEnumerator TestDamage() //FOR TESTING PURPOSE
    {
        yield return new WaitForSeconds(5);
        TakeDamage(9);
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(0.25f);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

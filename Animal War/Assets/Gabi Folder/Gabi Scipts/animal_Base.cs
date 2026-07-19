using System.Collections;
using UnityEngine;

public class animal_Base : MonoBehaviour
{


    public float maxHealth = 10f;
    public float currentHealth;
    public float speed = 2.0f;
    public int deathMoney = 5;
    private bool isDead = false;

    public Vector3 startScale = Vector3.one;
    public Vector3 endScale = new Vector3(3f, 3f, 3f);


    //WAYPOINT PATH
    private Transform[] waypoints;
    private int currentWaypoint = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        waypoints = waypointManager.Instance.waypoints;
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

        if (currentHealth <= 0 && !isDead)
        {
            isDead = true;
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
        if(!isDead)
        {
            waypointManager.Instance.addGold(deathMoney);
            isDead = true;
        }
        yield return new WaitForSeconds(0.25f);
        Destroy(gameObject);
    }

    void MoveAlongPath()
    {
        if (currentWaypoint >= waypoints.Length)
            return;

        // Direction toward next waypoint
        Vector3 dir = (waypoints[currentWaypoint].position - transform.position).normalized;

        // Move forward
        transform.position += dir * speed * Time.deltaTime;

        // Smooth rotation toward movement direction
        if (dir.sqrMagnitude > 0.001f)
        {
            Quaternion targetRot = Quaternion.LookRotation(dir);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, Time.deltaTime * 5f);
        }

        // Check if close enough to switch to next waypoint
        if (Vector3.Distance(transform.position, waypoints[currentWaypoint].position) < 0.2f)
        {
            currentWaypoint++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Respawn"))
        {
            StartCoroutine(Die());
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveAlongPath();
    }
}

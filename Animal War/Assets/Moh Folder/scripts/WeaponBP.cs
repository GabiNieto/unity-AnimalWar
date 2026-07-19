using UnityEngine;

public class WeaponBP : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float cooldown;
    public float nextShot;
    public GameObject proj;
    public Transform projSpawn;
    public bool isAOE;
    public float radius; //currently obselete

    void Start()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("proj")) return;
     if (other.CompareTag("Enemy") && Time.time >= nextShot)
        {
            Transform noseDirection = transform.parent;
            Vector3 direction = other.transform.position - noseDirection.position;
            direction.y = 0;

            noseDirection.rotation = Quaternion.LookRotation(direction);
            Instantiate(proj, noseDirection.position, noseDirection.rotation);
            Debug.Log("Shot");
            nextShot = Time.time + cooldown;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

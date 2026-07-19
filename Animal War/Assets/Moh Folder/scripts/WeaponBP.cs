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
    public float lifespan;
    public float dmg;

    void Start()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
     if (other.CompareTag("Enemy") && Time.time >= nextShot)
        {
            //parent gets affected here
            Transform noseDirection = transform.parent;
            Vector3 direction = other.transform.position - noseDirection.position;
            direction.y = 0;

            noseDirection.rotation = Quaternion.LookRotation(direction);
            GameObject shot = Instantiate(proj, noseDirection.position, noseDirection.rotation);
            
            Debug.Log("Shot");
            Destroy(shot, lifespan);
            nextShot = Time.time + cooldown;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

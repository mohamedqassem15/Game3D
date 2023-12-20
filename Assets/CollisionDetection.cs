using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    public weaponcontroller wp;
    public GameObject HitParticle;
    [SerializeField] int damage;

    private void OnCollisionEnter(Collision collider)
    {
        GameObject other = collider.gameObject;
        if (other.CompareTag("Enemy") && wp.getattcking())
        {
            EnemyHealthControler mything = other.GetComponent<EnemyHealthControler>();
            mything.takedamgae(damage);
            // Instantiate(HitParticle , new Vector3(other.transform.position.x,transform.position.y,other.transform.position.z),other.transform.rotation);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && wp.getattcking())
        {
            EnemyHealthControler mything = other.GetComponent<EnemyHealthControler>();
            mything.takedamgae(damage);
            // Instantiate(HitParticle , new Vector3(other.transform.position.x,transform.position.y,other.transform.position.z),other.transform.rotation);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    private GameObject player;
    [SerializeField] Rigidbody rb;
     [SerializeField] float distance;
    [SerializeField] int  damage;
    [SerializeField] float speed;
    [SerializeField] int chasedistance;
    private Vector3 lastpoition;
    [SerializeField] float tempdistance;
    private bool xorz= false;
    private  Transform start;
    private bool canattack = true;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");  
        start = player.transform;
        lastpoition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        followplayer();
        
    }

    private void followplayer() {
        transform.LookAt(player.transform);
        
        
        distance = Vector3.Distance(transform.localPosition, player.transform.localPosition);
        if (distance < 5 && canattack) {
            if (player.transform.localPosition.x + 5 < transform.localPosition.x)
            {
                rb.velocity = new Vector3(-speed*5, 0, rb.velocity.z);

            }
            else if (player.transform.localPosition.x - 5 > transform.localPosition.x)
            {
                rb.velocity = new Vector3(+speed*5, 0, rb.velocity.z);

            }



            if (player.transform.localPosition.z + 5 < transform.localPosition.z)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0, -speed * 5);

            }
            else if (player.transform.localPosition.z - 5 > transform.localPosition.z)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0, speed*5);

            }
           
            return;
        }
        if (distance < chasedistance) {
          
                if (player.transform.localPosition.x + 5 < transform.localPosition.x)
                {
                 rb.velocity = new Vector3(- speed, 0, rb.velocity.z);

                }
                else if (player.transform.localPosition.x - 5 > transform.localPosition.x)
                {
                    rb.velocity = new Vector3(+ speed, 0, rb.velocity.z);

                }
            
         
            
                if (player.transform.localPosition.z +5 < transform.localPosition.z )
                {
                    rb.velocity = new Vector3(rb.velocity.x, 0, - speed);

                }
                else if (player.transform.localPosition.z  - 5 > transform.localPosition.z)
                {
                    rb.velocity = new Vector3(rb.velocity.x, 0,  speed);

                }
           

        }
    }

    private void attack(reusablehealth playerhealth) {
        playerhealth.takedamage(damage);
        
    }
    private void OnCollisionEnter(Collision other) {
        GameObject currentobject = other.gameObject;
        if (currentobject.CompareTag("player") && canattack)
        {
            canattack = false;
            attack(currentobject.GetComponent<reusablehealth>());
            StartCoroutine(resetattackbool());
        }

    }
    IEnumerator resetattackbool()
    {
        yield return new WaitForSeconds(3f);
        canattack = true;
    }

}

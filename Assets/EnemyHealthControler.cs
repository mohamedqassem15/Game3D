using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthControler : MonoBehaviour
{
    [SerializeField] int hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0) { 
        Destroy(gameObject);
        }
    }
    public void takedamgae(int total) {
        hp = hp- total;
    }
}

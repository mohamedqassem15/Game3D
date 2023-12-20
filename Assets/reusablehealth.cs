using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reusablehealth : MonoBehaviour
{
    private int maxhealth;
    private int temp;
    [SerializeField] int health;
  //  [SerializeField] GameObject healthbarlocation;
    [SerializeField] increasedecrease healthbar;
    // Start is called before the first frame update
    void Start()
    {
   //     healthbar = healthbarlocation.GetComponent<increasedecrease>();
    //    maxhealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void takedamage(int attackdamage) {
        health-=attackdamage;
        healthbar.deacrease(attackdamage);


        if (health < 0) {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(5);

        }
    }

    // this has not been tested
    public void regenerate(int regenerate)
    {
        temp = health;
        health += regenerate;
        if (health > maxhealth) {
            healthbar.increase(maxhealth - temp);
            health = maxhealth;
            return;

        }

        healthbar.increase(regenerate);




    }
}

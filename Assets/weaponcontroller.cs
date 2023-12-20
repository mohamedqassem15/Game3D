using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponcontroller : MonoBehaviour
{
    [SerializeField] GameObject axe;
    private bool canattack = true;
    [SerializeField]Animator animator;
    public float attackcooldown = 1f;
    private bool isattacking = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
        if (Input.GetMouseButtonDown(0)) {
            if (canattack) {
                AxeAttack();


            }
        }
       
        
    }
    private void AxeAttack() {
        isattacking = true;
    canattack = false;
    animator = axe.GetComponent<Animator>();
        animator.SetTrigger("attacknow");
    StartCoroutine(ResetAttackCooldown());

    }
     IEnumerator ResetAttackCooldown() {
        StartCoroutine(resetattackbool());
        yield return new WaitForSeconds(attackcooldown);
        canattack = true;
      
           
        
    }
    IEnumerator resetattackbool() {
        yield return new WaitForSeconds(1f);
     isattacking=false;
    }
    public bool getattcking() {
        return isattacking;
    }
}

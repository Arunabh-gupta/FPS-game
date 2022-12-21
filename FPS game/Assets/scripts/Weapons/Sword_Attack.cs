using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Attack : MonoBehaviour
{
    [SerializeField] GameObject SwordObject;
    private bool CanAttack = true;
    [SerializeField]private float AttackCoolDown  = 0.5f;
    
    private void Update() {
        if(Input.GetMouseButtonDown(0) && gameObject.activeInHierarchy){
            if(CanAttack == true){
                _SwordAttack();
            }
        }
    }
    void _SwordAttack(){
        CanAttack = false;
        Animator anim = SwordObject.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        StartCoroutine(resetAttackCooldown());
    }
    IEnumerator resetAttackCooldown(){
        yield return new WaitForSeconds(AttackCoolDown);
        CanAttack = true;
    }
}

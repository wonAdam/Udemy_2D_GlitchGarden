using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    
    [Range(0f, 5f)] [SerializeField] float walkSpeed = 1f;
    GameObject currentTarget;


    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * walkSpeed);

        if(!currentTarget && GetComponent<Animator>().GetBool("IsAttacking")) 
            GetComponent<Animator>().SetBool("IsAttacking", false);
    }

    public void SetMovementSpeed(float speed){
        walkSpeed = speed;
    }

    public void Attack(GameObject target)
    {

        GetComponent<Animator>().SetBool("IsAttacking", true);
        currentTarget = target;

    }


    public void StrikeCurrentTarget(int damage)
    {

        if(!currentTarget) return;

        Health health = currentTarget.GetComponent<Health>();

        if(health != null)
        {

            health.DealDamage(damage);

        }

    }


}

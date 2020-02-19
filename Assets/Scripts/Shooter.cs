using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile;

    [SerializeField] GameObject gun;

    [SerializeField] Animator animator;

    public AttackerSpawner myLaneSpawner;

    void Start()
    {
        SetLaneSpawner();
    }

    void Update()
    {

        if(IsAttackerInLane())
        {
            // TODO : change animation state => shoot
            animator.SetBool("IsAttacking", true);

        }
        else
        {
            // TODO : change animation state => idle
            animator.SetBool("IsAttacking", false);

        }

    }


    private bool IsAttackerInLane()
    {

        // myLaneSpawner의 자식의 수가 0보다 크면 return true
        if(myLaneSpawner.transform.childCount > 0) return true;
        // 그외에는 return false
        else return false;
        
    }



    private void SetLaneSpawner()
    {

        var attackerSpawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in attackerSpawners)
        {

            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if(IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }

        }

    }
    

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);

        return;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] int health = 10;

    [SerializeField] GameObject deathVFX;
    // Start is called before the first frame update    
    
    public void DealDamage(int damage)
    {
        health -= damage;
        isDead();
    }

    public void isDead()
    {
        if(health <= 0)
        {
            if(deathVFX)
                TriggerDeathVFX();
                
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {

        if(!deathVFX) { return; }
        GameObject inst = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(inst, 1f);

    }
}

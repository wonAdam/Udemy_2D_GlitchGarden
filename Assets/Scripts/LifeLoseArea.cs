using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeLoseArea : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Attacker>() != null)
        {
            Destroy(other.gameObject);
            LifeText lifeText = FindObjectOfType<LifeText>();
            lifeText.LoseLifePoint(1);
        }
    }

}

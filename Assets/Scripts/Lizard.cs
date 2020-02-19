using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;

        if(otherObject.GetComponent<Defender>() != null) // if the other object has attacker component
        {

            // call public "Attack" method
            GetComponent<Attacker>().Attack(otherObject);

        }
    }

}

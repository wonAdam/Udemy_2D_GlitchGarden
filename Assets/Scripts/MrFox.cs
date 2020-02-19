using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrFox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;

        if(otherObject.GetComponent<Defender>() != null && otherObject.tag != "Gravestone") // if the other object has attacker component
        {

            // call public "Attack" method
            GetComponent<Attacker>().Attack(otherObject);

        }
        else if(otherObject.GetComponent<Defender>() != null && otherObject.tag == "Gravestone")
        {

            GetComponent<Animator>().SetTrigger("Jumping");

        }
    }
}

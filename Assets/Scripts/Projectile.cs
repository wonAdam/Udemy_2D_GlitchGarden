using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] float speed = 1f;
    [SerializeField] int damage = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Attacker>() != null)
        {
            other.GetComponent<Health>().DealDamage(damage);
            Destroy(gameObject);
        }
    }
}

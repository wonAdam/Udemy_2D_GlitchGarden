using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker attackerPrefab;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;

    bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start(){

        while(spawn){

            float sec = UnityEngine.Random.Range(1f, 5f);
            
            yield return new WaitForSeconds(sec);

            Instantiate(attackerPrefab, transform.position, transform.rotation);

        }
    }

}

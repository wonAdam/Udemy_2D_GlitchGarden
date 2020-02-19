using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker[] attackerPrefab;
    [SerializeField] bool randomSpawn = true;
    [SerializeField] int spawnIndex = 0;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;

    bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start(){

        while(spawn){

            float sec = UnityEngine.Random.Range(1f, 5f);


            int randomIndex;
            if(randomSpawn == true)
            {
                randomIndex = UnityEngine.Random.Range(0,attackerPrefab.Length);
            }
            else
            {
                randomIndex = spawnIndex;
            }

            yield return new WaitForSeconds(sec);

            Attacker newAttacker = Instantiate(attackerPrefab[randomIndex], transform.position, transform.rotation)
                                    as Attacker;

            newAttacker.transform.SetParent(transform);

        }
    }

}

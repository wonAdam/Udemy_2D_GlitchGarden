using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine("LoadLevel");
        }
    }

    public IEnumerator LoadLevel(){
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

}

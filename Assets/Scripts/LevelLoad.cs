using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("LoadLevel");
    }

    public IEnumerator LoadLevel(){
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }

}

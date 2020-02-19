using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeText : MonoBehaviour
{

    [SerializeField] int startLifePoint = 20;

    void Start()
    {
        GetComponent<Text>().text = startLifePoint.ToString();
    }

    public void LoseLifePoint(int amount)
    {
        int originalLife = int.Parse(GetComponent<Text>().text);
        originalLife -= amount;
        GetComponent<Text>().text = originalLife.ToString();
        if(originalLife <= 0) SceneManager.LoadScene("GameOver");
    }

}

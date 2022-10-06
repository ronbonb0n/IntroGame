using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public GameObject wintext;
    public PlayerController pc;
    public void Start()
    {
        scoretext.text = "Score: 0";
        score = 0;
        wintext.SetActive(false);

    }
    public void pickupcollected(GameObject pickup)
    {
        score++;
        scoretext.text = "Score: " + score.ToString();
        Destroy(pickup);

    }

    public void Update()
    {
        if (score >= 5)
        {
            wintext.SetActive(true);
            Destroy(pc);
        }

    }
}

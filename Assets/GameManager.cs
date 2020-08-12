using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Animator scorepop;
    public GameObject Startbtn,Player;
    public Text scoretxt;
    public static GameManager instance;
    public bool gameOver=false;
    public int score = 0;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    public void GameOver()
    {
        Startbtn.SetActive(true);
        gameOver = true;
        
        GameObject.Find("Enemy Spawn").GetComponent<EnemySpawner>().StopSpawning();
    }
    public void Reset()
    {
        score = 0;
        scoretxt.text = score.ToString();
        gameOver = false;
        Instantiate(Player);
    }
    public void IncreamentScore()
    {       
        if (!gameOver)
        {
            scorepop.Play("ScoreBounce");
            score++;
            scoretxt.text = score.ToString();
        }
    }
}

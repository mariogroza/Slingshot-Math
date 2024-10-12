using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{
    [HideInInspector]
    public static int score = 0;
    public static int clasa = 0;
    public static int health = 3;
    public TextMeshProUGUI points;
    public TextMeshProUGUI hp;
    public TextMeshProUGUI Clasa9;
    public TextMeshProUGUI Clasa10;
    public TextMeshProUGUI Clasa11;
    public TextMeshProUGUI Clasa12;
    public TextMeshProUGUI Clasa13;

    private void Start()
    {
        SetHighScore();
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0 && SceneManager.GetActiveScene().buildIndex !=82)
        {
            points.text = score + "";
            hp.text = health + "";
            HighScore();
        }
        
        if (health <= 0)
        {
            StartCoroutine(BackToMenu());
        }
    }
    IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(0);

        health = 3;
        score = 0;
    }

   public void HighScore()
    {
            if (clasa == 9)
            {
                if (score > PlayerPrefs.GetInt("HighScore9", 0))
                {
                    PlayerPrefs.SetInt("HighScore9", score);
                }
            }
            if (clasa == 10)
            {
                if (score > PlayerPrefs.GetInt("HighScore10", 0))
                {
                    PlayerPrefs.SetInt("HighScore10", score);
                }
            }
            if (clasa == 11)
            {
                if (score > PlayerPrefs.GetInt("HighScore11", 0))
                {
                    PlayerPrefs.SetInt("HighScore11", score);
                }
            }
            if (clasa == 12)
            {
                if (score > PlayerPrefs.GetInt("HighScore12", 0))
                {
                    PlayerPrefs.SetInt("HighScore12", score);
                }
            }
            if (clasa == 13)
            {
                if (score > PlayerPrefs.GetInt("HighScore13", 0))
                {
                    PlayerPrefs.SetInt("HighScore13", score);
                }
            }
        
    }
    public void SetHighScore()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Clasa9.text += PlayerPrefs.GetInt("HighScore9", 0) + "";
            Clasa10.text += PlayerPrefs.GetInt("HighScore10", 0) + "";
            Clasa11.text += PlayerPrefs.GetInt("HighScore11", 0) + "";
            Clasa12.text += PlayerPrefs.GetInt("HighScore12", 0) + "";
            Clasa13.text += PlayerPrefs.GetInt("HighScore13", 0) + "";
        }
    }

}

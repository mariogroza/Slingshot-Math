using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    public Canvas canvas;
    public Rigidbody2D question1, question2;
    public ScoreTracker st;
    Vector2 pozitie1;
    Vector2 pozitie2;

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0 && SceneManager.GetActiveScene().buildIndex != 82)
        {
            pozitie1 = new Vector2(question1.position.x, question1.position.y);
            pozitie2 = new Vector2(question2.position.x, question2.position.y);
            Randomize();
        }

    }

    public float transitionTime = 1f;

    public void clasa9()
    {
        ScoreTracker.clasa = 9;
    }
    public void clasa10()
    {
        ScoreTracker.clasa = 10;
    }
    public void clasa11()
    {
        ScoreTracker.clasa = 11;
    }
    public void clasa12()
    {
        ScoreTracker.clasa = 12;
    }
    public void clasa13()
    {
        ScoreTracker.clasa = 13;
    }

    public void Tutorial()
    {
        StartCoroutine(LoadLevel(82));
    }

   public void BackToMenu()
    {
        StartCoroutine(LoadLevel(0));
    }

    public void SelectRandomLevel()
    {
        if (ScoreTracker.clasa==9)
        { 
            StartCoroutine(LoadLevel(Random.Range(1, 26))); 
        }
        if(ScoreTracker.clasa==10)
        {
            StartCoroutine(LoadLevel(Random.Range(26, 47)));
        }
        if (ScoreTracker.clasa == 11)
        {
            StartCoroutine(LoadLevel(Random.Range(47, 66)));
        }
        if (ScoreTracker.clasa == 12)
        {
            StartCoroutine(LoadLevel(Random.Range(66, 82)));
        }
        if (ScoreTracker.clasa == 13)
        {
            StartCoroutine(LoadLevel(Random.Range(1, 82)));
        }
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            canvas.enabled = false;
        }
        else
        {
            canvas.enabled = true;
        }
    }

    public void Randomize()
    {
        if (Random.Range(1, 100) < 50)
        {
            question1.transform.position = pozitie1;
            question2.transform.position = pozitie2;
        }
        else
        {
            question1.transform.position = pozitie2;
            question2.transform.position = pozitie1;
        }
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 82)
        {
            transition.SetTrigger("Start");
        }
           
        yield return new WaitForSeconds(transitionTime);
        
        SceneManager.LoadScene(levelIndex);
    }

}

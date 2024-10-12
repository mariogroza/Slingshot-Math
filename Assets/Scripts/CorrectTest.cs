using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CorrectTest : MonoBehaviour
{
    public ParticleSystem corect;
    public ParticleSystem gresit;
    public Rigidbody2D circle;
    public LevelLoader ll;
    public AudioPlayer ap;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Corect")
        {
            ll.question1.gameObject.SetActive(false);
            ll.question2.gameObject.SetActive(false);
            corect.Play();
            circle.gameObject.SetActive(false);
            ll.SelectRandomLevel();
            ScoreTracker.score+=10;
            ap.PlayAudioCorect();
        }
        else
        if (collision.gameObject.tag == "Gresit")
        {
            ll.question1.gameObject.SetActive(false);
            ll.question2.gameObject.SetActive(false);
            gresit.Play();
            circle.gameObject.SetActive(false);
            ll.SelectRandomLevel();
            ScoreTracker.health--;
            ap.PlayAudioGresit();
        }
        
    }
}

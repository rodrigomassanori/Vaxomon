using UnityEngine;

public class Music :  MonoBehaviour 
{
    AudioSource music;

    void Awake()
    {
        music = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D pl)
    {
        if(pl.gameObject.tag == "Player")
        {
            music.Play();
        }
    }

    void OnCollisionExit2D(Collision2D pl)
    {
        if(pl.gameObject.tag == "Player")
        {
            music.Stop();
        }
    }    
}
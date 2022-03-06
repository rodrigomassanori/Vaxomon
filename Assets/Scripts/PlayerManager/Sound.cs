using UnityEngine;

public class Sound : MonoBehaviour 
{
    AudioSource sound;

    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D pl)
    {
        if(pl.gameObject.tag == "Player")
        {
            sound.Play();
        }
    }

    void OnCollisionExit2D(Collision2D pl)
    {
        if(pl.gameObject.tag == "Player")
        {
            sound.Stop();
        }
    }
}
using UnityEngine;
using System.Collections;

public class HorrorSound : MonoBehaviour
{
    AudioSource sound;

    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D pl)
    {
        if(pl.gameObject.tag == "Player")
        {
            StartCoroutine(PlaySound());
        }
    }

    void OnTriggerExit2D(Collider2D pl)
    {
        if(pl.gameObject.tag == "Player")
        {
            StartCoroutine(StopSound());
        }
    }

    IEnumerator PlaySound()
    {
        yield return new WaitForSeconds(0.5f);

        sound.Play();
    }

    IEnumerator StopSound()
    {
        yield return new WaitForSeconds(0.5f);

        sound.Stop();
    }
}
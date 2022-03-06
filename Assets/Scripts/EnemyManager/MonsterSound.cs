using UnityEngine;
using System.Collections;

public class MonsterSound : MonoBehaviour
{
    AudioSource sound;

    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D npc)
    {
        if(npc.gameObject.tag == "NPC")
        {
            StartCoroutine(PlaySound());
        }
    }

    void OnTriggerExit2D(Collider2D npc)
    {
        if(npc.gameObject.tag == "NPC")
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
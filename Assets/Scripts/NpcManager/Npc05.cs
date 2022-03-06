using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Npc05 : MonoBehaviour
{
    public Text npcTalk;

    void OnCollisionEnter2D(Collision2D pl)
    {
        if (pl.gameObject.tag == "Player")
        {
            StartCoroutine(Talk());
        }
    }

    IEnumerator Talk()
    {
        yield return new WaitForSeconds(6.0f);

        npcTalk.enabled = true;

        npcTalk.text = "Do you want to know the truth...about why u´re a vaxomon?";

        yield return new WaitForSeconds(5.5f);

        npcTalk.enabled = false;

        yield return new WaitForSeconds(6.0f);

        npcTalk.enabled = true;

        npcTalk.text = "You´ll never know, cause u´ll be a vaxomon forever";

        yield return new WaitForSeconds(5.5f);

        npcTalk.enabled = false;

        yield return new WaitForSeconds(6.0f);

        npcTalk.enabled = true;

        npcTalk.text = "Go now and find stairs";
    }

    void OnCollisionExit2D(Collision2D pl)
    {
        if (pl.gameObject.tag == "Player")
        {
            StartCoroutine(EndTalk());
        }
    }

    IEnumerator EndTalk()
    {
        yield return new WaitForSeconds(5.5f);

        npcTalk.enabled = false;
    }
}
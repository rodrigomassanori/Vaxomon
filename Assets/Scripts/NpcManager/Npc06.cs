using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Npc06 : MonoBehaviour
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
        yield return new WaitForSeconds(1.5f);

        npcTalk.enabled = true;

        npcTalk.text = "Find a cave to go for the side of this forest";

        yield return new WaitForSeconds(5.5f);

        npcTalk.enabled = false;
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
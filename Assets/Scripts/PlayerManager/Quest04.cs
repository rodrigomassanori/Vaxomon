using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Quest04 : MonoBehaviour
{
    public Text NpcTalk;

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

        NpcTalk.enabled = true;

        NpcTalk.text = "What? U saw Tysavil in a forest near here?";

        yield return new WaitForSeconds(5.5f);

        NpcTalk.enabled = false;

        yield return new WaitForSeconds(1.5f);

        NpcTalk.enabled = true;

        NpcTalk.text = "Why u went to see him?";

        yield return new WaitForSeconds(5.5f);

        NpcTalk.enabled = false;

        yield return new WaitForSeconds(1.5f);

        NpcTalk.enabled = true;

        NpcTalk.text = "Do u want to know more about Tisavyl?...\n So Read all the notes in this house";
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

        NpcTalk.enabled = false;
    }
}
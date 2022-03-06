using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Quest03 : MonoBehaviour 
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
        yield return new WaitForSeconds(5.5f);

        NpcTalk.enabled = true;

        NpcTalk.text = "Oh, so you escaped from the house?, Right! \n Go to explore and find your second partner!";

        yield return new WaitForSeconds(5.5f);

        NpcTalk.enabled = false;

        yield return new WaitForSeconds(90.5f);

        NpcTalk.enabled = true;

        NpcTalk.text = "This is your partner? Ok, \n find a note in the third house!";

        yield return new WaitForSeconds(5.5f);

        NpcTalk.enabled = false;
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
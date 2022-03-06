using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Npc02 : MonoBehaviour 
{
    public Text npcTalk;

    void Start () 
    {
        StartCoroutine (Talk ());

        StartCoroutine (EndTalk ());
    }

    IEnumerator Talk () 
    {
        yield return new WaitForSeconds (1.5f);

        npcTalk.enabled = true;

        npcTalk.text = "Hey u, Where re u going? Come back here";

        yield return new WaitForSeconds (5.5f);

        npcTalk.enabled = false;

        yield return new WaitForSeconds (5.5f);

        npcTalk.enabled = true;

        npcTalk.text = "Zarmak, GET AWAY FROM THIS...FROM HIM NOW!";

        yield return new WaitForSeconds (5.5f);

        npcTalk.enabled = false;
    }

    IEnumerator EndTalk () 
    {
        yield return new WaitForSeconds (5.5f);

        npcTalk.enabled = false;
    }
}
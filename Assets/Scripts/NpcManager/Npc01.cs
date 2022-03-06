using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Npc01 : MonoBehaviour 
{
    public Text npcTalk;

    void Start () 
    {
        StartCoroutine (Talk ());

        StartCoroutine (EndTalk ());
    }

    IEnumerator Talk () 
    {
        yield return new WaitForSeconds (8.0f);

        npcTalk.enabled = true;

        npcTalk.text = "You know there is a story about a little vaxomon \n that touched a creature who lives in a forest near here?";

        yield return new WaitForSeconds (5.5f);

        npcTalk.enabled = false;
    }

    IEnumerator EndTalk () 
    {
        yield return new WaitForSeconds (5.5f);

        npcTalk.enabled = false;
    }
}
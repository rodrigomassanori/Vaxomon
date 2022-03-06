using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Npc04 : MonoBehaviour
{
    public Text npcTalk;

    void Start()
    {
        StartCoroutine(Talk());

        StartCoroutine(EndTalk());
    }

    IEnumerator Talk()
    {
        yield return new WaitForSeconds(6.0f);

        npcTalk.enabled = true;

        npcTalk.text = "Don´t trust in..., Oh...i remember now, \n i can´t say his name...but be carefull";

        yield return new WaitForSeconds(5.5f);

        npcTalk.enabled = false;
    }

    IEnumerator EndTalk()
    {
        yield return new WaitForSeconds(5.5f);

        npcTalk.enabled = false;
    }
}
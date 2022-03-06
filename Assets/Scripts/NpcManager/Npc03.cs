using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Npc03 : MonoBehaviour
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

        npcTalk.text = "Hi little Zarmak, do u need something?";

        yield return new WaitForSeconds(5.5f);

        npcTalk.enabled = false;
    }

    IEnumerator EndTalk()
    {
        yield return new WaitForSeconds(5.5f);

        npcTalk.enabled = false;
    }
}
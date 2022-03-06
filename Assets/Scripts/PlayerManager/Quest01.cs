using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Quest01 : MonoBehaviour
{
    public Text quests;

    void Start()
    {
        StartCoroutine(ShowQuest01());
    }

    IEnumerator ShowQuest01()
    {
        quests.enabled = false;

        yield return new WaitForSeconds(0.5f);

        quests.enabled = true;

        quests.text = "Survive for 2 minutes";

        yield return new WaitForSeconds(8.0f);

        quests.enabled = false;

        StopCoroutine(ShowQuest01());
    }
}
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Quest05 : MonoBehaviour 
{
    public Text QuestFinal;

    void Start()
    {
        StartCoroutine(ShowQuest());

        StartCoroutine(EndQuest());
    }

    IEnumerator ShowQuest()
    {
        yield return new WaitForSeconds(5.5f);

        QuestFinal.text = "Find a new partner for your team";

        yield return new WaitForSeconds(6.0f);

        QuestFinal.enabled = false;
    }

    IEnumerator EndQuest()
    {
        yield return new WaitForSeconds(6.0f);

        QuestFinal.enabled = false;
    }
}
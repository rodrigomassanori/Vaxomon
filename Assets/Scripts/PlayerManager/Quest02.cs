using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Quest02 : MonoBehaviour 
{
    public Text quests;

    void Start()
    {
        StartCoroutine(ShowQuest02());
    }

    IEnumerator ShowQuest02()
    {
        quests.enabled = false;

        yield return new WaitForSeconds(0.5f);

        quests.enabled = true;

        quests.text = "Find a key to open the door";

        yield return new WaitForSeconds(10.0f);

        quests.enabled = false;

        yield return new WaitForSeconds(15.0f);

        quests.enabled = true;

        quests.text = "Escape from the house!";

        yield return new WaitForSeconds(10.0f);

        quests.enabled = false;

        yield return new WaitForSeconds(15.0f);

        quests.enabled = true;

        quests.text = "You escaped from the house";

        yield return new WaitForSeconds(8.0f);

        quests.enabled = false;

        StopCoroutine(ShowQuest02());
    }
}
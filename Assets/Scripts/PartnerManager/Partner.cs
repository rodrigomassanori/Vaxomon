using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Partner : MonoBehaviour 
{
    public Text partnerTalk;

    void Start()
    {
        StartCoroutine(Talk());

        StartCoroutine(EndTalk());
    }

    IEnumerator Talk()
    {
        yield return new WaitForSeconds(1.5f);

        partnerTalk.enabled = true;

        partnerTalk.text = "Explore this forest and find a house like your appearence";

        yield return new WaitForSeconds(5.5f);

        partnerTalk.enabled = false;

        yield return new WaitForSeconds(10.5f);

        partnerTalk.enabled = true;

        partnerTalk.text = "Lets go inside to the house \n and explore it while we search for the mystery there!";

        yield return new WaitForSeconds(5.5f);

        partnerTalk.enabled = false;

        StopCoroutine(Talk());
    }

    IEnumerator EndTalk()
    {
        yield return new WaitForSeconds(5.5f);

        partnerTalk.enabled = false;

        StopCoroutine(EndTalk());
    }
}
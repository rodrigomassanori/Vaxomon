using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MissionHouse : MonoBehaviour 
{
    public Text HouseInside;

    void Start() 
    {
        StartCoroutine(ShowMissionInside());
    }

    IEnumerator ShowMissionInside() 
    {
        yield return new WaitForSeconds(1.5f);

        HouseInside.enabled = true;

        HouseInside.text = "Discover all the mysteries, \n while explore and look about a way to transform you as human, inside this house";

        yield return new WaitForSeconds(5.5f);

        HouseInside.enabled = false;

        yield return new WaitForSeconds(5.5f);

        HouseInside.enabled = true;

        HouseInside.text = "Find a key on 5th floor in this house!";

        yield return new WaitForSeconds(5.5f);

        HouseInside.enabled = false;

        StopCoroutine(ShowMissionInside());
    }
}
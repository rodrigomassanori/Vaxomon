using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MissionHouse2 : MonoBehaviour 
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

        HouseInside.text = "Find stairs on this floor";

        yield return new WaitForSeconds(5.5f);

        HouseInside.enabled = false;

        StopCoroutine(ShowMissionInside());
    }
}
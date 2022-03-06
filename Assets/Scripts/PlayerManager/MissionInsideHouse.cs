using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MissionInsideHouse : MonoBehaviour
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

        HouseInside.text = "Run From Wilco";

        yield return new WaitForSeconds(5.5f);

        HouseInside.enabled = false;

        StopCoroutine(ShowMissionInside());
    }
}
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissionFailed : MonoBehaviour
{
    public Text Failed;

    KeyCode e = KeyCode.E;

    void Start()
    {
        Failed.enabled = false;

        StartCoroutine(TryAgain());
    }

    IEnumerator TryAgain()
    {
        yield return new WaitForSeconds(1.5f);

        Failed.enabled = true;

        Failed.text = "You died in this house!";

        yield return new WaitForSeconds(5.5f);

        Failed.enabled = false;

        yield return new WaitForSeconds(1.5f);

        Failed.enabled = true;

        Failed.text = "Press E to try again!";
    }

    void Update()
    {
        if (Input.GetKeyDown(e))
        {
            SceneManager.LoadScene("InteriorHouse4");
        }
    }
}
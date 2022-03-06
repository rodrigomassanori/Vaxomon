using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Note : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D pl)
    {
        if (pl.gameObject.tag == "Player")
        {
            Cutscene();
        }
    }

    void Cutscene()
    {
        StartCoroutine(CutsceneGame());
    }

    IEnumerator CutsceneGame()
    {
        yield return new WaitForSeconds(4.5f);

        SceneManager.LoadScene("Cutscene2");
    }
}
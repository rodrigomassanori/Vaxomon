using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D pl)
    {
        if (pl.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver2");
        }
    }
}
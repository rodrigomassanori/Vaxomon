using UnityEngine;
using UnityEngine.SceneManagement;

public class Pentagram2 : MonoBehaviour 
{
    void OnCollisionEnter2D(Collision2D pl)
    {
        if (pl.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}
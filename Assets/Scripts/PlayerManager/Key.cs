using UnityEngine;

public class Key : MonoBehaviour
{
    public SpriteRenderer key;

    void Start()
    {
        key.enabled = true;
    }
    
    void OnCollisionEnter2D(Collision2D pl)
    {
        if(pl.gameObject.tag == "Player")
        {
            DestroyKey();
        }
    }

    void DestroyKey()
    {
        key.gameObject.SetActive(false);
    }
}
using UnityEngine;

public class Rope : MonoBehaviour
{
    public SpriteRenderer rope;

    void Start()
    {
        rope.enabled = true;
    }
    
    void OnCollisionEnter2D(Collision2D pl)
    {
        if(pl.gameObject.tag == "Player")
        {
            DestroyRope();
        }
    }

    void DestroyRope()
    {
        rope.gameObject.SetActive(false);
    }
}
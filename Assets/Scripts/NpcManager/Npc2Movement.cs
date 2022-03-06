using System.Collections.Generic;
using UnityEngine;

public class Npc2Movement : MonoBehaviour 
{
    Rigidbody2D rb;

    public Transform Npc03;

    SpriteRenderer sp;

    public List<Sprite> spr;

    Vector2 direction;

    float walk = 1.1f;

    void Awake () 
    {
        rb = GetComponent<Rigidbody2D> ();

        sp = GetComponent<SpriteRenderer> ();
    }

    void Update () 
    {
        if (Vector2.Distance (transform.position, Npc03.transform.position) > 0.2f &&
        Npc03.gameObject.tag == "NPC") 
        {
            direction = (Vector2) (Npc03.transform.position - transform.position).normalized;

            float rotation = Mathf.Atan2 (direction.x, direction.y) / Mathf.PI * 0.5f + 0.5f;

            sp.sprite = spr[(int) Mathf.Round (rotation * 4) % 4];

            rb.MovePosition ((Vector2) transform.position + direction * walk * Time.fixedDeltaTime);
        }
    }
}
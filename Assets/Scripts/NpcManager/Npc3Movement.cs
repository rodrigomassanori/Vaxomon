using System.Collections.Generic;
using UnityEngine;

public class Npc3Movement : MonoBehaviour 
{
    AudioSource FootStep;

    Rigidbody2D rb;

    public Transform House3;

    SpriteRenderer sp;

    public List<Sprite> spr;

    Vector2 direction;

    float walk = 1.1f;

    void Awake () 
    {
        FootStep = GetComponent<AudioSource>();

        rb = GetComponent<Rigidbody2D> ();

        sp = GetComponent<SpriteRenderer> ();
    }

    void Update () 
    {
        if (Vector2.Distance (transform.position, House3.transform.position) > 0.2f &&
        House3.gameObject.tag == "House3") 
        {
            direction = (Vector2) (House3.transform.position - transform.position).normalized;

            float rotation = Mathf.Atan2 (direction.x, direction.y) / Mathf.PI * 0.5f + 0.5f;

            sp.sprite = spr[(int) Mathf.Round (rotation * 4) % 4];

            rb.MovePosition ((Vector2) transform.position + direction * walk * Time.fixedDeltaTime);

            FootStep.loop = true;

            FootStep.Play();
        }
    }
}
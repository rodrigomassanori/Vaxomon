using UnityEngine;
using System.Collections.Generic;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rb;

    AudioSource FootStep;

    public Transform pl;

    SpriteRenderer sp;

    public List<Sprite> spr;

    Vector2 direction;

    float walk = 2.5f;

    void Awake()
    {
        FootStep = GetComponent<AudioSource>();

        rb = GetComponent<Rigidbody2D>();

        sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, pl.transform.position) > 0.5f
		&& pl.gameObject.tag == "Player")
		{
            direction = (Vector2)(pl.transform.position - transform.position).normalized;
			
			float rotation = Mathf.Atan2(direction.x, direction.y) / Mathf.PI * 0.5f + 0.5f;

            sp.sprite = spr[(int)Mathf.Round(rotation * 4) % 4];

            FootStep.Play();
			
			rb.MovePosition((Vector2)transform.position + direction * walk * Time.fixedDeltaTime);
        }
    }
}
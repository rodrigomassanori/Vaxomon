using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    SpriteRenderer sp;
    
    public List<Sprite> spr;

    KeyCode d = KeyCode.D;

    KeyCode a = KeyCode.A;

    KeyCode w = KeyCode.W;

    KeyCode s = KeyCode.S;

    KeyCode Up = KeyCode.UpArrow;

    KeyCode Down = KeyCode.DownArrow;

    KeyCode Left = KeyCode.LeftArrow;

    KeyCode Right = KeyCode.RightArrow;

    float walk = 4.5f;

    int move;

    void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Walk();
    }

    void Walk()
    {
        move = 0;

        if(Input.GetKey(d) || Input.GetKey(Right))
        {
            move++;

            sp.sprite = spr[0];

            transform.Translate(new Vector2(walk * Time.deltaTime, 0.0f));
        }

        if(Input.GetKey(a) || Input.GetKey(Left))
        {
            move--;

            sp.sprite = spr[1];

            transform.Translate(new Vector2(-walk * Time.deltaTime, 0.0f));
        }

        if(Input.GetKey(w) || Input.GetKey(Up))
        {
            move++;

            sp.sprite = spr[2];

            transform.Translate(new Vector2(0.0f, walk * Time.deltaTime));
        }

        if(Input.GetKey(s) || Input.GetKey(Down))
        {
            move--;

            sp.sprite = spr[3];

            transform.Translate(new Vector2(0.0f, -walk * Time.deltaTime));
        }
    }
}
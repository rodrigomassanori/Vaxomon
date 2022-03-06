using UnityEngine;

public class DoorHouse : MonoBehaviour 
{
    public SpriteRenderer Door;

    void OnCollisionEnter2D(Collision2D pl)
    {
        if(pl.gameObject.tag == "Player")
        {
            Door.enabled = false;

            Door.gameObject.SetActive(false);
        }
    }
}
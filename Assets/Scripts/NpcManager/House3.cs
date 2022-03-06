using UnityEngine;

public class House3 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D npc04)
    {
        if(npc04.gameObject.tag == "NPC")
        {
            npc04.gameObject.SetActive(false);
        }
    }
}
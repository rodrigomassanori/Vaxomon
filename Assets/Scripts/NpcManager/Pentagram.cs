using UnityEngine;

public class Pentagram : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D npc03)
    {
        if (npc03.gameObject.tag == "NPC")
        {
            npc03.gameObject.SetActive(false);
        }
    }
}
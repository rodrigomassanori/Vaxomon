using UnityEngine;

public class FuneralCasket : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D npc03)
    {
        if (npc03.gameObject.tag == "NPC")
        {
            npc03.gameObject.SetActive(false);
        }
    }
}
using System.Collections;
using UnityEngine;

public class Cage : MonoBehaviour
{
    public GameObject cage;

    public GameObject Partner;

    void OnCollisionEnter2D(Collision2D pl)
    {
        if(pl.gameObject.tag == "Player")
        {
            StartCoroutine(SavePartner());
        }
    }

    IEnumerator SavePartner()
    {
        yield return new WaitForSeconds(1.0f);

        Partner.SetActive(true);

        yield return new WaitForSeconds(1.0f);

        cage.SetActive(false);
    }
}
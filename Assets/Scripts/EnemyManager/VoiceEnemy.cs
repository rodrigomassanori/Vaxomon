using UnityEngine;

public class VoiceEnemy : MonoBehaviour 
{
    AudioSource sound;

    KeyCode z = KeyCode.Z;

    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(z))
        {
            sound.Play();
        }
    }    
}
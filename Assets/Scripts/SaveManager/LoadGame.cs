using UnityEngine;

public class LoadGame : MonoBehaviour
{
    void Start()
    {
        Load();
    }

    public void Load()
    {
        transform.position = new Vector2(PlayerPrefs.GetFloat("Player position in x"), 
        PlayerPrefs.GetFloat("Player position in y"));
        
        print("Game Loaded");
    }
}
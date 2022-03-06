using UnityEngine;

public class SaveGame : MonoBehaviour
{
    void Start()
    {
        Save();
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("Player position in x saved", transform.position.x);

        PlayerPrefs.SetFloat("Player position in y saved", transform.position.y);

        print("Game Saved");
    }
}
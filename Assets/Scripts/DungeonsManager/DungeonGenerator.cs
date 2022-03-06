using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public GameObject[] Floor;

    public GameObject[] Walls;

    void Start()
    {
        for (int x = 0; x < Floor.Length * 100; x++)
        {
            for (int y = 0; y < Floor.Length * 100; y++)
            {
                Instantiate(Floor[0], new Vector2(x, y), Quaternion.identity);
            }
        }

        for (int x = 0; x < Walls.Length * 20; x++)
        {
            Instantiate(Walls[0], new Vector2(x, Walls.Length), Quaternion.identity);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DungeonGenerator2 : MonoBehaviour
{
    [SerializeField] Grid areaGrid;
    [SerializeField] Grid childGrid;
    //[SerializeField] List<Tilemap> listOfAreas;
    [SerializeField] List<Grid> listOfAreas;
    [SerializeField] int mapSizeX;
    [SerializeField] int mapSizeY;

    // Start is called before the first frame update
    void Start()
    {
        GenerateTheDungeon();
    }

    void GenerateTheDungeon()
    {
        int maxRandomValue = listOfAreas.Count;
        int choosedArea = 0;
        if (maxRandomValue != 0)
        {
            for (int i = 0; i < mapSizeX; i++)
            {
                for (int j = 0; j < mapSizeY; j++)
                {
                    choosedArea = Random.Range(0, maxRandomValue);
                    PlaceTheArea(i, j, choosedArea);
                    //Debug.Log("Na posição (" + i + "," + j + ") foi colocado o " + choosedArea);
                }
            }
        }
    }

    void PlaceTheArea(int x, int y, int area)
    {
        Grid instantiatedAre;
        Vector3Int girdCoordinates = new Vector3Int(x, y, 0);
        Vector3 wordCoordinates = new Vector3(0, 0, 0);
        wordCoordinates = areaGrid.CellToWorld(girdCoordinates);
        instantiatedAre = Instantiate(listOfAreas[area], areaGrid.transform);
        instantiatedAre.transform.SetPositionAndRotation(wordCoordinates, Quaternion.identity);
    }

}

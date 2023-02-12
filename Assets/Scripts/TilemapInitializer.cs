using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using UnityEngine.Tilemaps;
using Random = System.Random;

public class TilemapInitializer : MonoBehaviour
{
    public Tilemap map;
    public Tile tile;
    // Start is called before the first frame update
    void Start()
    {
        var rand = new Random();
        for (int i = -10; i <= 10; i++)
        {
            for(int j = -10; j <= 10; j++)
            {
                if(rand.Next(1, 11) == 1)
                {
                    map.SetTile(new Vector3Int(i, j, 0), tile);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

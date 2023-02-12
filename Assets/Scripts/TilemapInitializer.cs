using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapInitializer : MonoBehaviour
{
    public Tilemap map;
    public Tile tile;
    // Start is called before the first frame update
    void Start()
    {
        map.SetTile(new Vector3Int(1, 1, 0), tile);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

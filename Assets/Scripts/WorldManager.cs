using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Random = System.Random;

public class WorldManager : MonoBehaviour
{
    public Tilemap obstacleMap;
    public Tile obstacleTile1;

    public Tilemap objectMap;
    public Tile objectTile1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Obstacles");
        var rand = new Random();
        for (int i = -10; i <= 10; i++)
        {
            for (int j = -10; j <= 10; j++)
            {
                var randInt = rand.Next(1, 11);
                if (randInt == 1)
                {
                    obstacleMap.SetTile(new Vector3Int(i, j, 0), obstacleTile1);
                }
                if (randInt == 2)
                {
                    objectMap.SetTile(new Vector3Int(i, j, 0), objectTile1);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBoard : MonoBehaviour
{
    [SerializeField] GameObject lightTile;
    [SerializeField] GameObject darkTile;

    int tileCount;

    void Start()
    {
        tileCount = 0;
        GenerateGameBoard();
        //PlacePieces();
    }

    void PlacePieces()
    {
        throw new NotImplementedException();
    }

    void GenerateGameBoard()
    {
        for (int column = 0; column < 8; column++)
        {
            for (int row = 0; row < 8; row++)
            {
                bool lightOrDarkTile = (column + row) % 2 != 0;
                GameObject tile = lightOrDarkTile ? lightTile : darkTile;

                Vector2 location = new Vector2(-3.5f + column, -3.5f + row);

                tile.name = $"{tileCount}";
                Instantiate(tile, location, Quaternion.identity);
                tileCount++;
            }
        }
    }
}

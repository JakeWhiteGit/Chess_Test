using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBoard : MonoBehaviour
{
    [SerializeField] GameObject lightTile;
    [SerializeField] GameObject darkTile;

    int rowNumber = 1;
    int columnNumber = 0;
    enum columnLetter
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H
    }

    void Start()
    {
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

                tile.name = $"{(columnLetter)columnNumber}{rowNumber}";
                Instantiate(tile, location, Quaternion.identity);
                rowNumber++;
            }
            columnNumber++;
            rowNumber = 1;
        }
    }
}

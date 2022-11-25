using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBoard : MonoBehaviour
{
    [SerializeField] Color lightTile;
    [SerializeField] Color darkTile;

    [SerializeField] GameObject tile;

    SpriteRenderer tileSpriteRenderer;

    int tileCount;

    void Awake()
    {
        tileSpriteRenderer = tile.GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        GenerateGameBoard();
    }

    void GenerateGameBoard()
    {
        for (int column = 0; column < 8; column++)
        {
            for (int row = 0; row < 8; row++)
            {
                bool lightOrDarkTile = (column + row) % 2 != 0;
                Color tileColor = lightOrDarkTile ? lightTile : darkTile;
                Vector2 location = new Vector2(-3.5f + column, -3.5f + row);

                Instantiate(tile, transform);
                tile.transform.position = location;
                tileSpriteRenderer.color = tileColor;
                tile.name = $"{tileCount}";
                tileCount++;
            }
        }
    }
}

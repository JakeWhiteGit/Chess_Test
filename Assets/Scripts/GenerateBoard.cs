using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBoard : MonoBehaviour
{
    [SerializeField] GameObject lightTile;
    [SerializeField] GameObject darkTile;

    [SerializeField] GameObject b;
    [SerializeField] GameObject k;
    [SerializeField] GameObject n;
    [SerializeField] GameObject p;
    [SerializeField] GameObject q;
    [SerializeField] GameObject r;
    [SerializeField] GameObject B;
    [SerializeField] GameObject K;
    [SerializeField] GameObject N;
    [SerializeField] GameObject P;
    [SerializeField] GameObject Q;
    [SerializeField] GameObject R;

    public GameObject[] tiles = new GameObject[64];

    FenTranslator fenTranslator;

    int rowNumber = 8;
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

    void Awake()
    {
        fenTranslator = GetComponent<FenTranslator>();
    }

    void Start()
    {
        GenerateGameBoard();
        PlacePieces(fenTranslator.PiecePosition);
    }

    //Horrible code for taking the first part of the fen notation and laying out the pieces
    //with a giant switch statement
    void PlacePieces(string piecePosition)
    {
        int count = 0;
        char[] characters = piecePosition.ToCharArray();
        foreach (var character in characters)
        {
            switch (character.ToString())
            {
                case ("b"):
                    Instantiate(b, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("k"):
                    Instantiate(k, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("n"):
                    Instantiate(n, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("p"):
                    Instantiate(p, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("q"):
                    Instantiate(q, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("r"):
                    Instantiate(r, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("B"):
                    Instantiate(B, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("K"):
                    Instantiate(K, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("N"):
                    Instantiate(N, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("P"):
                    Instantiate(P, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("Q"):
                    Instantiate(Q, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("R"):
                    Instantiate(R, tiles[count].transform.position, Quaternion.identity, tiles[count].transform);
                    count++;
                    break;
                case ("/"):
                    
                    break;
                case ("1"):
                    count += 1;
                    break;
                case ("2"):
                    count += 2;
                    break;
                case ("3"):
                    count += 3;
                    break;
                case ("4"):
                    count += 4;
                    break;
                case ("5"):
                    count += 5;
                    break;
                case ("6"):
                    count += 6;
                    break;
                case ("7"):
                    count += 7;
                    break;
                case ("8"):
                    count += 8;
                    break;
                default:
                    Debug.Log("Invalid FEN");
                    break;
            }
        }
    }

    void GenerateGameBoard()
    {
        int count = 0;
        for (int row = 8; row > 0; row--)
        {
            for (int column = 0; column < 8; column++)
            {
                bool lightOrDarkTile = (column + row) % 2 != 0;
                GameObject tile = lightOrDarkTile ? lightTile : darkTile;

                Vector2 location = new Vector2(-3.5f + column, -3.5f + row);

                tile.name = $"{(columnLetter)columnNumber}{rowNumber}";
                tiles[count] = Instantiate(tile, location, Quaternion.identity);
                count++;
                columnNumber++;
            }
            rowNumber--;
            columnNumber = 0;
        }
    }
}

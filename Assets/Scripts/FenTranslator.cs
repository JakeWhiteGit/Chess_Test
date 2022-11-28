using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenTranslator : MonoBehaviour
{
    [SerializeField] string startingFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

    [HideInInspector]
    public string PiecePosition,
                  Turn,
                  Castling,
                  Passant,
                  HalfMoves,
                  WholeMoves;

    int spaceCounter = 0;

    void Start()
    {
        PartitionFEN();
    }

    private void PartitionFEN()
    {
        foreach (char character in startingFEN)
        {
            if (character.ToString() == " ") { spaceCounter++; continue; }

            switch (spaceCounter)
            {
                case 0:
                    PiecePosition += character;
                    break;
                case 1:
                    Turn += character;
                    break;
                case 2:
                    Castling += character;
                    break;
                case 3:
                    Passant += character;
                    break;
                case 4:
                    HalfMoves += character;
                    break;
                case 5:
                    WholeMoves += character;
                    break;
            }
        }
    }
}

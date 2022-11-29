using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    PlayerInput playerInput;
    bool isGrabbed = false;
    [SerializeField][Range(1,6)] int type;

    public enum Type
    {
        pawn,
        king,
        queen,
        rook,
        bishop,
        knight
    }

    void Awake()
    {
        playerInput = FindObjectOfType<PlayerInput>();
    }

    void Start()
    {
         
    }

    void OnMouseEnter()
    {
        transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
    }

    void OnMouseExit()
    {
        transform.localScale = Vector3.one;
    }

    void OnMouseDown()
    {
        isGrabbed = !isGrabbed;
    }

    void OnMouseUp()
    {
    }

    void Update()
    {
        if (!isGrabbed) { return; }
        transform.position = playerInput.MousePosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public Vector2 MousePosition;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}

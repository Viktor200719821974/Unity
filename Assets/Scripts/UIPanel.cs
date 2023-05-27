using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class UIPanel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Vector2 pos;
    public Snake snake;

    public void OnPointerUp(PointerEventData e)
    {
        float right = pos.x - e.position.x;
        float up = pos.y - e.position.y;
    
        if (Math.Abs(right) - Math.Abs(up) > 0) {
            if (right < 0)
                snake.Right();
            else
                snake.Left();
        }
        
        else {
            if (up < 0)
                snake.Up();
            else
                snake.Down();
        }
        
    }

    public void OnPointerDown(PointerEventData e) 
    {
        pos = e.position;
    }

    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") == -1) 
        {
        // Code to move left
            snake.Left();
        } 
        else if (Input.GetAxisRaw("Horizontal") == 1) {
        // Code to move right
            snake.Right();
        }

        if (Input.GetAxisRaw("Vertical") == -1)
        {
        // Code to move down or squat
            snake.Down();
        }
        else if (Input.GetAxisRaw("Vertical") == 1)
        {
        // Code to move up or jump
            snake.Up();
        }
    }

}

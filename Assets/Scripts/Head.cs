using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Snake snake;
    public GameController GC;
    public Score score;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Fruite") {
            snake.Eat();
            score.UpScore();
        }
        else
        {
            GC.GameReload();
        }
        
    }
}

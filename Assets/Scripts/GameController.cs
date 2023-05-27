using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Snake snake;
    public Fruits fruits;
    public Score score;

    public Text fail;
    public Text win;
    Text text;
    bool is_text_active = false;

    public void GameReload(bool isfail = true){

        snake.Reload();
        fruits.NewFruit();
        score.ReloadScore();
        text = null;
        if(isfail)
            text = fail;
        else
            text = win;
        
        text.gameObject.SetActive(true);
        timer = 0;
        is_text_active = true;

    }

    float timer = 0;

    void Update(){
        if(is_text_active && timer > 5){
            text.gameObject.SetActive(false);
            is_text_active = false;

        }
        
        timer += Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameController GC;

    int score = 0;
    int sizeHeight = 30;
    int max_score;

    void Start()
    {
        int height = (int)(sizeHeight / 3.4f) -1;
        int width = (int)((Screen.width / (Screen.height / sizeHeight) - 1.7f) / 3.4f) - 1;

        max_score = height * width - 4;
    }

    public void UpScore()
    {
        score++;
        GetComponent<Text>().text = score.ToString();

        if (score == max_score)
            GC.GameReload(false);
    }

    public void ReloadScore()
    {
        score = 0;
        GetComponent<Text>().text = score.ToString(); 
    }
}

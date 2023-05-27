using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    public GameObject grape;
    public GameObject apple;
    public GameObject pear;
    
    int height = 0;

    int width  = 0;

    int sizeHeight = 30;

    int speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        height = (int)(sizeHeight / 3.4f) -1;
        width = (int)((Screen.width / (Screen.height / sizeHeight) - 1.7f) / 3.4f) - 1;
    }

    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        if (timer * speed < 0) {
            if (GetComponentInChildren<Fruite>() != null)
                Destroy(GetComponentInChildren<Fruite>().gameObject);
            GenerateFruite();
            timer = height + width;
        }   
        timer -= Time.deltaTime;
    }

    public void NewFruit() 
    {
        timer = -1;
    }

    void GenerateFruite() 
    {
        int ind = Random.Range(0, 3);
        GameObject frut;

        switch (ind)
        {
            case 0:
                frut = grape;
                break;
            case 1:
                frut = apple;
                break;
            default:
                frut = pear;
                break;
        }

        int[] arr = {-1, 1};
        int x = Random.Range(0, width) * arr[Random.Range(0, 2)];
        int y = Random.Range(0, height) * arr[Random.Range(0, 2)];

        Instantiate(frut, new Vector3(x * 3.4f, y * 3.4f, 10), Quaternion.identity, transform);
    }
}

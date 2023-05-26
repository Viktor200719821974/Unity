using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence : MonoBehaviour
{
    float screenWidth;
    float screenHeight;

    public GameObject prefabBox;

    // Start is called before the first frame update
    void Start()
    {
        screenHeight = 30;
        screenWidth = (Screen.width / (Screen.height / screenHeight)) - 1.7f;

        int x = (int)(screenWidth / 3.4f);
        int y = (int)(screenHeight / 3.4f);

        for (int i = 0; i <= x; i++) {
            Instantiate(prefabBox, new Vector3(i * 3.4f, y * 3.4f, 0), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector3(- i * 3.4f, y * 3.4f, 0), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector3(i * 3.4f, - y * 3.4f, 0), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector3(- i * 3.4f, - y * 3.4f, 0), Quaternion.identity, transform);
        }

        for (int i = 0; i < y; i++) {
            Instantiate(prefabBox, new Vector3(x * 3.4f, i * 3.4f, 0), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector3(- x * 3.4f, i * 3.4f, 0), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector3(x * 3.4f, - i * 3.4f, 0), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector3(- x * 3.4f, - i * 3.4f, 0), Quaternion.identity, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

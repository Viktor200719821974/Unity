using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruite : MonoBehaviour
{
    public Fruits fruits;

    void OnTriggerEnter2D(Collider2D other) 
    {
            Destroy(gameObject);

            GetComponentInParent<Fruits>().NewFruit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnetic : MonoBehaviour
{
    public bool isSafe;

    public GameObject player; //외부에 있는 플레이어를 참조

    public float currentSize = 35;
    private void Update()
    {
        currentSize -= Time.deltaTime;
        if(currentSize <=1)
        {
            currentSize = 1;
        }
        transform.localScale = Vector3.one * currentSize;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isSafe = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isSafe = false; 
            Destroy(player);

        }
    }
}

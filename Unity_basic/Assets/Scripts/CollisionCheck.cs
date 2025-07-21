using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{

    //용암에 들어온 상태
    public bool isLava;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "이 충돌함");
            Debug.Log("현재 상태가 용암에 빠진 상태입니다.");
            isLava = true; 
        }
       
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "이 충돌상태에서 벗어남");
            Debug.Log("현재 상태가 용암 상태가 아닙니다.");
            isLava = false;
        }
       

    }
}

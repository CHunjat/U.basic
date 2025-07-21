using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // collider2D
    {

        if (collision.CompareTag("Enemy")) // Tag 이름이 Enemy 일때만 아래코드를 실행하세요
        {
            

            // 1.충돌한 대상을 파괴시켜 보세요
            Destroy(collision.gameObject);
            
            // 2. 충돌한 자기 자신을 파괴시켜 보세요.
            //Destroy(gameObject); // 트리거체크에 접목되있는 나자신을 부숴라 
        }

        //조건문 
        // tag가 플레이어 일때 실행하는 코드
        // 

        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Player와 충돌한 대상이 파괴 되었습니다 대상 : " + gameObject.name);
        }

    }
}


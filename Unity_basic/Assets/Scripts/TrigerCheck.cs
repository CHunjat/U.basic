using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // collider2D
    {

        if (collision.CompareTag("Enemy")) // Tag �̸��� Enemy �϶��� �Ʒ��ڵ带 �����ϼ���
        {
            

            // 1.�浹�� ����� �ı����� ������
            Destroy(collision.gameObject);
            
            // 2. �浹�� �ڱ� �ڽ��� �ı����� ������.
            //Destroy(gameObject); // Ʈ����üũ�� ������ִ� ���ڽ��� �ν��� 
        }

        //���ǹ� 
        // tag�� �÷��̾� �϶� �����ϴ� �ڵ�
        // 

        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Player�� �浹�� ����� �ı� �Ǿ����ϴ� ��� : " + gameObject.name);
        }

    }
}


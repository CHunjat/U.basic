using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxcollider2D;
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Vector2 moveVector;
    private void Start()
    {
        rigidbody2D.velocity = moveVector.normalized;
      
    }

    private void Update()
    {

        // WŰ�� �Է������� X=0, Y=1 MOVEVECTOR�� �Ǿ��
        // AŰ�� �Է������� X=-1, Y=0 MOVEVECTOR�� �Ǿ��
        // SŰ�� �Է������� X=0, Y=-1 MOVEVECTOR�� �Ǿ��
        // DŰ�� �Է������� X=1, Y=0 MOVEVECTOR�� �Ǿ��
        // �׸��� space�� �Է��ϸ� BoxCollider2D�� ��Ȱ��ȭ����
        if(Input.GetKeyDown(KeyCode.W))
        {
            moveVector = new Vector2(0, 1);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            moveVector = new Vector2(-1, 0);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            moveVector = new Vector2(0, -1);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            moveVector = new Vector2(1, 0);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            boxcollider2D.enabled = false;
        }
        rigidbody2D.velocity = moveVector* moveSpeed;
    }
}

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

        // W키를 입력했으면 X=0, Y=1 MOVEVECTOR가 되어라
        // A키를 입력했으면 X=-1, Y=0 MOVEVECTOR가 되어라
        // S키를 입력했으면 X=0, Y=-1 MOVEVECTOR가 되어라
        // D키를 입력했으면 X=1, Y=0 MOVEVECTOR가 되어라
        // 그리고 space를 입력하면 BoxCollider2D를 비활성화하자
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rd;
    float xInput, yInput;
    public float speed,xLimit;
    Vector2 newPosition;
    private void Awake()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        xInput = Input.GetAxis("Horizontal");
        //yInput = Input.GetAxis("Vertical");
        newPosition = transform.position;
        newPosition.x += xInput * speed;
        //newPosition.y += yInput * speed;
        newPosition.x=Mathf.Clamp(newPosition.x, -xLimit, xLimit);
        rd.MovePosition(newPosition);


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAction : MonoBehaviour
{
    [SerializeField] private float fallMultiplier = 1.5f;

    [SerializeField] private float lowJumpMultiplier = 1f;
   
    private Rigidbody2D playerRB;
    private int jumpVelocity;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            
            if (playerRB.velocity.y <= 0)
            { 
                playerRB.velocity += Vector2.up * Physics2D.gravity.y * fallMultiplier * Time.deltaTime;
               
                transform.position = Vector2.up * playerRB.velocity;
            }
            else if (playerRB.velocity.y > 0 && !Input.GetButtonDown("Jump"))
            {
                playerRB.velocity += Vector2.up * Physics2D.gravity.y * lowJumpMultiplier * Time.deltaTime;
                transform.position = Vector2.up * playerRB.velocity;
            }
        }
        
    }
}

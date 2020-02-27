
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
	public int moveSpeed;
	private Animator anim; 
    private Rigidbody2D playerRigidBody;

    private bool isMoving;
    public Vector2 lastMove;

    
   
    private static bool playerAlreadyExists;
    public Vector3 moveDirection;
    
    void Start()
    {
        moveSpeed = 5;
        anim = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody2D>();
        

        if (!playerAlreadyExists){
            playerAlreadyExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else {
            Destroy (gameObject);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        isMoving = false;
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0);
        
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -.5f)
        {
            
        	//transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f,0f));
            playerRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), playerRigidBody.velocity.y*moveSpeed);
            isMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            transform.position = Vector2.MoveTowards(transform.position, transform.position + moveDirection, moveSpeed * Time.deltaTime);
            
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -.5f)
        {
           
        	//transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime,0f));
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x*moveSpeed, Input.GetAxisRaw("Vertical"));
            isMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
            transform.position = Vector2.MoveTowards(transform.position, transform.position + moveDirection, moveSpeed * Time.deltaTime);
            
        }

        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f){
            playerRigidBody.velocity = new Vector2(0f, playerRigidBody.velocity.y);
            
        }
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5){
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, 0f);
            
        }
        

        //if (Input.GetButtonDown("Submit"))
          //  {
                
          //  }
    anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
    anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    anim.SetBool("isMoving", isMoving);
    anim.SetFloat("LastMoveX", lastMove.x);
    anim.SetFloat("LastMoveY", lastMove.y);

    }
}

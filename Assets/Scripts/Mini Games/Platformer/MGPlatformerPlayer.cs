using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGPlatformerPlayer : MonoBehaviour {
    #region Variable Declarations
    public float speed;
    public float speedMultiplier;
    public static int scoreCounter;

    public float speedIncreaseMilestone, speedMilestoneCount;
    public float jumpForce, jumpTime;

    private float jumpTimeCounter;

    public int speedLevelCounter;

    public float startingPitch;

    private float moveInput;

    private Rigidbody2D rb;

    public bool isOnGround;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask thisIsGround;

    //private Collider2D myCollider;
    AudioSource audioSource;
    #endregion
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        //myCollider = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();

        audioSource.pitch = startingPitch;

        jumpTimeCounter = jumpTime;
    }

    void Update()
    {
        scoreCounter++;


        isOnGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, thisIsGround);

        speedLevelCounter++;
        if(speedLevelCounter >= 1600)
        {
            speed = 3.75f;
            audioSource.pitch = 1.08f;
        }
        if (speedLevelCounter >= 3000)
        {
            speed = 4.75f;
            audioSource.pitch = 1.13f;
        }
        if (speedLevelCounter >= 4200)
        {
            speed = 5.5f;
            audioSource.pitch = 1.2f;
        }
        if (speedLevelCounter >= 4800)
        {
            speed = 3; //Hardcoded value - must correspond to the starting value of speed
            audioSource.pitch = 1;
            speedLevelCounter = 0;
        }
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.W) || Input.GetMouseButtonDown(0))
        {
            if(isOnGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }

        if(Input.GetKey(KeyCode.W) || Input.GetMouseButton(0))
        {
            if(jumpTimeCounter > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
        }

        if(Input.GetKeyUp(KeyCode.W) || Input.GetMouseButtonUp(0))
        {
            jumpTimeCounter = 0;
        }

        if(isOnGround)
        {
            jumpTimeCounter = jumpTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public float jumpForce;
    public float speed;
    private Rigidbody2D rb;
    //private SpriteRenderer spriteRenderer;

    public bool facingRight = true;

    private bool isGrounded = false;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public float move;
    public static int CoinCount = 0;

    public DeathMenu deathmenu;

    public FinisMenu finishmenu;

    public Text CoinCounter;



    private Animator anim;
    void Start()
    {
        Debug.Log("Start");
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        //rb.isKinematic = false;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        //move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        


        /*if (facingRight == false && move > 0)
        {
            Flip();
        }
        else if (facingRight == true && move < 0)
        {
            Flip();
        }*/


        //Debug.Log(move* speed);
        //Debug.Log(move * speed*0.1);
        //Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        //transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        //Debug.Log(speed * Time.deltaTime);
        //float x = Input.GetAxis("Horizontal");
        //Vector3 move = new Vector3(transform.position, rb.velocity.y, 0f);

    }

    public void ButtonGoLeft()
    {
        Debug.Log("go");
        move = -1f;
        anim.SetBool("isGo", true);
        if(facingRight == true) Flip();
    }

    public void ButtonGoRight()
    {
        anim.SetBool("isGo", true);
        move = 1f;
        if (facingRight == false) Flip();
        
    }
    public void ButtontUp()
    {
        anim.SetBool("isGo", false);
        move = 0f;
    }

    public void Jump()
    {
        if (isGrounded)
        {
            Debug.Log("jump");
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }

    void Flip()
    {
        Debug.Log("Flip");

        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("jump");
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }

    




    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag.Equals("DeathZone"))
        {
            Destroy(gameObject);
            deathmenu.LoadDeathScreen();
        }
        if (collision.tag.Equals("Coins"))
        {
            /*CoinCollect.coinCount = +1;
            CoinCollectSave.coin = +1;
            Destroy(collision.gameObject);*/
            CoinCount += 1;
            CoinCounter.text = "x" + CoinCount;
            Destroy(collision.gameObject);
            Debug.Log(CoinCount);
        }
        if (collision.tag.Equals("FinishZone"))
        {
            Time.timeScale = 0f;
            finishmenu.LoadWinScreen();
            Destroy(gameObject);
        }

    }



    




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public static movement instance;
    private float dirX = 0f;
    private float speed = 5f;
    [SerializeField] private int starcount = 0;
    private MovementState state;
    [SerializeField] private float jumpforce = 24f;
    [SerializeField] private float airspeed = 3f;
    [SerializeField] private LayerMask layer;
    [SerializeField] private LayerMask currency;
    private BoxCollider2D box;
    private CircleCollider2D circle;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private enum MovementState { IDLE, RUNNING, JUMPING, FALLING, }

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        circle = GetComponent<CircleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        dirX = Input.GetAxisRaw("Horizontal");
        if (IsGrounded())
        {
            rb.velocity = new Vector2(dirX * speed, rb.velocity.y); //sets the movements speed to normal speed while on ground
        }
        else
        {
            rb.velocity = new Vector2(dirX * airspeed, rb.velocity.y); //slows the movement speed while in the air

        }

        if (Input.GetButtonDown("Jump") && IsGrounded()) //jumps only while on ground to prevent doube jumping
        {

            rb.velocity = new Vector2(rb.velocity.x, jumpforce);

        }
      
        animstate();
        Flip();

        Debug.Log(starcount);
    }

    private void Flip() //flips sprite
    {
        if (dirX > 0f)
        {

            sprite.flipX = false;

        }
        else if (dirX < 0f)
        {
            sprite.flipX = true;
        }
    }
    private bool IsGrounded() //raycast method to check wether sprite is on ground
    {
        RaycastHit2D rayhit = Physics2D.Raycast(box.bounds.center, Vector2.down, box.bounds.extents.y + 0.15f, layer);
        Color color;
        if (rayhit.collider != null)
        {
            color = Color.green;

        }
        else { color = Color.red; }
        Debug.DrawRay(box.bounds.center, Vector2.down * (box.bounds.extents.y + 0.1f), color);
        Debug.Log(rayhit.collider);
        return rayhit.collider != null;
    }

    private void animstate()
    {

        if (dirX > 0f)
        {
            state = MovementState.RUNNING;

            //sprite.flipX = false;

        }
        else if (dirX < 0f)
        {
            state = MovementState.RUNNING;
            //sprite.flipX = true;

        }
        else
        {
            state = MovementState.IDLE;


        }
        anim.SetInteger("state", (int)state);

    }

    public void collect(int val) 
    {
      starcount+=val;



    }
}

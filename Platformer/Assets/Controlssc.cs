using UnityEngine;

public class Controlssc : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    [SerializeField]
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private float horizontalInput;

    void Start()
    {
    
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        horizontalInput = Input.GetAxisRaw("Horizontal");
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius,whatIsGround);

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {

        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    private const float MoveSpeed = 30f;
    private const float JumpForce = 22f;
    private Rigidbody2D _rb;
    private GroundCollider _groundDetector;
    public HealthManager _healthManager;
    public Animator animator;
    public SpriteRenderer _sr;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _groundDetector = GetComponentInChildren<GroundCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //left/right mouvement
        MoveLeftRight();

        //jump
        Jump();

        if (_groundDetector.isGrounded)
        {
            animator.SetBool("IsJumping", false);
        }
        else
        {
            animator.SetBool("IsJumping", true);
        }
    }

    private void Jump()
    {
        if (Input.GetAxis("Jump") > Mathf.Epsilon && _groundDetector.isGrounded == true)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, Input.GetAxis("Jump") * JumpForce);
        }
    }

    private void MoveLeftRight()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) >= Mathf.Epsilon)
        {
            //_rb.position += new Vector2(Input.GetAxis("Horizontal") * MoveSpeed, 0) * (Time.deltaTime * MoveSpeed);
            _rb.velocity += new Vector2(Input.GetAxis("Horizontal") * MoveSpeed, 0) * (Time.deltaTime * MoveSpeed);
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
            _rb.velocityX = 0;
        }

        FlipSprite();

        SpeedLimit();
    }

    private void SpeedLimit()
    {
        if (_rb.velocityX > 7)
        {
            _rb.velocityX = 7;
        }
        else if (_rb.velocityX < -7)
        {
            _rb.velocityX = -7;
        }
    }

    private void FlipSprite()
    {
        if (_rb.velocity.x <= -0.1f)
        {
            _sr.flipX = true;
        }
        else if (_rb.velocity.x >= 0.1f)
        {
            _sr.flipX = false;
        }
    }
}
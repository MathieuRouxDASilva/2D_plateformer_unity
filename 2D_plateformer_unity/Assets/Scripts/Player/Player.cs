using UnityEngine;

public class Player : MonoBehaviour
{
    //private float _moveSpeed = 5f;
    private const float JumpForce = 100.0f;
    private Rigidbody2D _rb;
    private GroundCollider _groundDetector;


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
        _rb.velocity = Vector2.right * (Input.GetAxis("Horizontal") * 4.0f);

        //jump

        if (Input.GetAxis("Jump") >= Mathf.Epsilon && _groundDetector.isGrounded == true)
        {
            _rb.velocity += Vector2.up * (Input.GetAxis("Jump") * JumpForce);
        }
    }
}
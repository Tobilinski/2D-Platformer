using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //PlayerBody
    protected Rigidbody2D Rb;
    private GameObject _playerBody;
    //Animation
    public SpriteRenderer Sr;
    private Animator _animator;
    private Animation _animation;
    //Raycast
    private BoxCollider2D _boxCollider2D;
    [SerializeField] private LayerMask _layerMask;
    
    //LevelLoader
    public GameObject LevelLoader;
    //Stars Import
    public Star Stars;
    //Speeds
    private float runSpeed, jumpSpeed;
    // Prticle system
    public ParticleSystem Dust;
    public ParticleSystem Kindle;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Sr = GetComponent<SpriteRenderer>();
        _boxCollider2D = transform.GetComponent<BoxCollider2D>();
        _animator = GetComponent<Animator>();
        _animation = gameObject.GetComponent<Animation>();

        runSpeed = 10f;
        jumpSpeed = 25f;
        Stars.StarNm = 0;   
    }


    void Update()
    {
        Move();
        Kindle.Play();
    }

    void Move()
    {

        if (Input.GetKey(KeyCode.A))
        {

            Sr.flipX = true;
            Rb.velocity = new Vector2(-runSpeed, Rb.velocity.y);
            _animator.SetBool("IsRunning", true);
            Dust.Play();
            //Debug.Log("running");

        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {

                Sr.flipX = false;
                Rb.velocity = new Vector2(+runSpeed, Rb.velocity.y);
                _animator.SetBool("IsRunning", true);
                //Debug.Log("running");
                Dust.Play();

            }
            else
            {
                Rb.velocity = new Vector2(0f, Rb.velocity.y);
                _animator.SetBool("IsRunning", false);
            }
        }

        if (_isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {

            Rb.velocity = Vector2.up * jumpSpeed;
            _animator.SetBool("IsJumping", true);
            Dust.Play();
            //Debug.Log("jump");
           
        }
        else
        {
            _animator.SetBool("IsJumping", false);
        }
        
    }



    private bool _isGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(_boxCollider2D.bounds.center, _boxCollider2D.bounds.size, 0f, Vector2.down, .1f, _layerMask);

        // print(raycastHit2D.collider);

        return raycastHit2D.collider != null;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Stars.StarNm == 1 && other.gameObject.tag == "NextLevel" )
        {
            Debug.Log("null");
            LevelLoader.GetComponent<LevelLoader>().NextLevel();          
        }
    }

    
}

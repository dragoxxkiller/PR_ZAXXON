using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Anim : MonoBehaviour
{

    Animator animator;
    Rigidbody2D rb;
    [SerializeField] float JumpForce;

    [SerializeField] float distanciaSuelo;


    // Start is called before the first frame update
    void Start()
    {
        JumpForce = 8f;

        animator = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();

        distanciaSuelo = 0.15f;
    }

    // Update is called once per frame
    void Update()
    {

        PlayerControl();

    }

    void PlayerControl()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, 1f) * JumpForce, ForceMode2D.Impulse);
            animator.SetTrigger("salto");

        }

        if(rb.velocity.y < -0.25f)
        {
            animator.SetBool("caida", true);
        }



        Debug.DrawRay(transform.position, Vector2.down * 0.15f, Color.red);


        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);
        if (hit.collider != null)
        {
            
            animator.SetBool("caida", false);
            animator.SetBool("ensuelo", true);
           
        }
        else
        {
            animator.SetBool("IsGrounded", false);
        }
    }






}

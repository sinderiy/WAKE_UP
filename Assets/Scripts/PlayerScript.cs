using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public float maxSpeed = 5f;
    bool facingRight = true;
    private Rigidbody2D rigid2D;
    Animator anim;
    

    void Start ()
    {
        anim = GetComponent<Animator>();
        rigid2D = GetComponent<Rigidbody2D>();
       
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Physics2D.IgnoreLayerCollision(8, 9);
        float move = Input.GetAxis("Horizontal");
        rigid2D.velocity = new Vector3(move * maxSpeed, rigid2D.velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(move));
        if (move > 0 && !facingRight)
                   Flip();
        else if (move < 0 && facingRight)
                   Flip();
         
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    
}

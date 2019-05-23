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
       BlackOut.FadeScreen(Color.black, 1, 0, 1);
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

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Monster")
        {
            FindObjectOfType<NoMoves>().DontMove();
            BlackOut.FadeScreen(Color.white, 0, 1, 1.5f, () => Application.LoadLevel("Photo"));
        }
    }
   public void StopMove()
    {
        anim.SetFloat("Speed", 0);
    }
    public void StartMove()
    {
        anim.SetFloat("Speed", 0.1f);
    }
}

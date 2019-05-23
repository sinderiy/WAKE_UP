using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMoves : MonoBehaviour
{
   public void DontMove()
    {
       GetComponent<PlayerScript>().enabled = false;
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        FindObjectOfType<PlayerScript>().StopMove();
    }
    public void Move()
    {
      GetComponent<PlayerScript>().enabled = true;
        gameObject.GetComponent<Rigidbody2D>().constraints &= ~RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        FindObjectOfType<PlayerScript>().StartMove();
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnclikableObject : MonoBehaviour
{
  public void Unclikable()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
    public void Clikable()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }
}

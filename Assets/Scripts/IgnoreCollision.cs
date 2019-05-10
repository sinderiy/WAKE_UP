using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour {

    public Transform trash;

    void Start()
    {
        var Neit = Instantiate(trash) as Transform;
        Physics2D.IgnoreCollision(Neit.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Monster : MonoBehaviour
{

    // Start is called before the first frame update
    public void CollisionTrigger()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        StartCoroutine(Test());
    }
    IEnumerator Test()
    {
        yield return new WaitForSeconds(1.2f);
        gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
    }

}

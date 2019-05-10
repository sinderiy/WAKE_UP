using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrasherScript : MonoBehaviour {

    public GameObject Text;
    public GameObject Line;

    void Start ()
    {
        Text.SetActive(false);
        Line.SetActive(false);
    }
    public void OnMouseDown()
    {
        gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
    public void OnMouseOver()
    {
        Text.SetActive(true);
        Line.SetActive(true);
    }
    public void OnMouseExit()
    {
        Text.SetActive(false);
        Line.SetActive(false);
    }
}

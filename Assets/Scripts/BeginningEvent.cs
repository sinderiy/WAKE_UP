using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class BeginningEvent : MonoBehaviour
{
    public GameObject Text;
    public GameObject Line;
    public SpriteRenderer[] parents = new SpriteRenderer[6];
    // Start is called before the first frame update
    void Start()
    {
        Text.SetActive(false);
        Line.SetActive(false);
    }

    public void OnMouseDown()
    {
        gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
        InvokeRepeating("Animation0", 3, 0);
    }

    void Animation0()
    {
        parents[0].enabled = false; //убрали родителей
        parents[5].enabled = true; //включили черный фон
        parents[1].enabled = true; //появился 1 кадр монстра
        InvokeRepeating("Animation1", 0.6f, 0);
    }

    void Animation1()
    {
        parents[5].enabled = false;//убрали черный фон
        
       // parents[2].enabled = true;
        InvokeRepeating("Animation2", 0.4f, 0);
    }
    void Animation2()
    {
        parents[5].enabled = true; //показали черный фон
        parents[1].enabled = false; //убрали 1 кадр
        parents[2].enabled = true; //показали 2 кадр
        InvokeRepeating("Animation3", 0.6f, 0);
    }
    void Animation3()
    {
        parents[5].enabled = false;//убрали черный фон
        InvokeRepeating("Animation4", 0.4f, 0);
    }
    void Animation4()
    {
        parents[5].enabled = true; //показали черный фон
        parents[2].enabled = false; //убрали 2 кадр
        parents[3].enabled = true; //показали 3 кадр
        InvokeRepeating("Animation5", 0.8f, 0);
    }
    void Animation5()
    {
        parents[5].enabled = false;//убрали черный фон
        InvokeRepeating("Animation6", 0.6f, 0);
    }
    void Animation6()
    {
        parents[5].enabled = true; //показали черный фон
        parents[3].enabled = false; //убрали 2 кадр
        parents[4].enabled = true; //показали 3 кадр
        InvokeRepeating("Animation7", 0.6f, 0);
    }
    void Animation7()
    {
        parents[5].enabled = false;//убрали черный фон
        
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

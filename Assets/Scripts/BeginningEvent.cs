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

        InvokeRepeating("Animation0", 2, 0);
    }

    void Animation0()
    {
        parents[0].enabled = false; //убрали родителей
        parents[5].enabled = true; //включили черный фон
        parents[1].enabled = true; //появился 1 кадр монстра
        InvokeRepeating("Animation1", 0.2f, 0);
    }

    void Animation1()
    {
        parents[5].enabled = false;//убрали черный фон
        FindObjectOfType<Contrast>().ContrastOn();
        InvokeRepeating("AnimationA", 0.4f, 0);
    }
    void AnimationA()
    {
        parents[5].enabled = true; // вернули черный фон
        FindObjectOfType<Contrast>().ContrastOff();
        InvokeRepeating("AnimationB", 0.1f, 0);
    }
    void AnimationB()
    {
        parents[5].enabled = false;//убрали черный фон
        FindObjectOfType<Contrast>().ContrastOn();
        InvokeRepeating("Animation2", 0.1f, 0);
    }
    void Animation2()
    {
        FindObjectOfType<Contrast>().ContrastOff();
        parents[5].enabled = true; // вернули черный фон
        parents[1].enabled = false; //убрали 1 кадр
        parents[2].enabled = true; //показали 2 кадр
        InvokeRepeating("Animation3", 0.6f, 0);
    }
    void Animation3()
    {
        parents[5].enabled = false;//убрали черный фон
        FindObjectOfType<Contrast>().ContrastOn();
        InvokeRepeating("AnimationC", 0.4f, 0);
    }
    void AnimationC()
    {
        FindObjectOfType<Contrast>().ContrastOff();
        parents[5].enabled = true;// вернули черный фон
        InvokeRepeating("AnimationD", 0.2f, 0);
    }
    void AnimationD()
    {
        parents[5].enabled = false;//убрали черный фон
        InvokeRepeating("Animation4", 0.1f, 0);
    }
    void Animation4()
    {
        parents[5].enabled = true; // вернули черный фон
        parents[2].enabled = false; 
        parents[3].enabled = true; 
        InvokeRepeating("Animation5", 0.8f, 0);
    }
    void Animation5()
    {
        parents[5].enabled = false;//убрали черный фон
        FindObjectOfType<Contrast>().ContrastOn();
        InvokeRepeating("AnimationE", 0.6f, 0);
    }
    void AnimationE()
    {
        parents[5].enabled = true;// вернули черный фон
        FindObjectOfType<Contrast>().ContrastOff();
        InvokeRepeating("AnimationF", 0.1f, 0);
    }
    void AnimationF()
    {
        parents[5].enabled = false;//убрали черный фон
        InvokeRepeating("Animation6", 0.2f, 0);
    }
    void Animation6()
    {
        parents[5].enabled = true; // вернули черный фон
        parents[3].enabled = false; 
        parents[4].enabled = true; 
        InvokeRepeating("Animation7", 0.6f, 0);
    }
    void Animation7()
    {
        parents[5].enabled = false;//убрали черный фон
        InvokeRepeating("Animation8", 0.6f, 0);
    }
        void Animation8()
    {
        parents[5].enabled = true; // вернули черный фон
        parents[4].enabled = false; 
        parents[6].enabled = true; 
        
        InvokeRepeating("Animation19", 0.6f, 0);
        FindObjectOfType<Monster>().CollisionTrigger();  
    }
    void Animation19()
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

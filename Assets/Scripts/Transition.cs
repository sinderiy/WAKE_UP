﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public GameObject Text;
    public GameObject Line;
   
    void Start()
    {
        Text.SetActive(false);
        Line.SetActive(false);
    }

    public void OnMouseDown()
    {
        BlackOut.FadeScreen(Color.black, 0, 1, 1, () => Application.LoadLevel("LoungeRoom"));
        //Application.LoadLevel("LoungeRoom");
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

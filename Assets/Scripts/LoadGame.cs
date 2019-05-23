using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    public void OnMouseDown()
    {
       Application.LoadLevel("SampleScene");
    }
}

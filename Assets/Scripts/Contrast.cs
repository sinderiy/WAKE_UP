using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class Contrast : MonoBehaviour
{
    public void ContrastOn()
    {
        GetComponent<ContrastStretch>().enabled = true; 
    }
    public void ContrastOff()
    {
        GetComponent<ContrastStretch>().enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHidden : MonoBehaviour
{
    public SpriteRenderer[] parents = new SpriteRenderer[5];
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in parents)
        {
            item.enabled = false;
        }
    }

    
}

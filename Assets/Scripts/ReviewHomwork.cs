using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class ReviewHomwork : MonoBehaviour
{
    public int visible_word = 2;
    private int invisible_word = 1;
    private bool i_can_spam = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.O))
        {
            print("Nooo, stop spamming");
            i_can_spam=false;
        }
        if (i_can_spam)
        {
            print("haha I’m spamming");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHomework : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            print("I'm being touched!");
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            print("I'm still touched!");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            print("I'm not touched");
        }
    }
}

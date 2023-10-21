using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventScript : MonoBehaviour
{
    public Person indentity;
    public UnityEvent on_touch_ball;
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
        if (collision.collider.tag == "Ball")
        {
            on_touch_ball.Invoke();
        }
    }
}

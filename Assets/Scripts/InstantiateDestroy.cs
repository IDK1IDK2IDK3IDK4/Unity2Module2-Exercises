using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class InstantiateDestroy : MonoBehaviour
{
    //create variables below 
    public GameObject object_clone;
    public float destroy_delay = 5;
    public int ash_count = 0;

    // Update is called once per frame
    void Update()
    {
        //WRITE CODE HERE
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GameObject Instantiate_Object;
            Instantiate_Object = Instantiate(object_clone);
            Destroy(Instantiate_Object, 9);
            ash_count += 1;
            print(ash_count);
        }
        //END OF CODE
    }
}

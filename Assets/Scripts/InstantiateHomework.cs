using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateHomework : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj_To_Spawn;
    void Start()
    {
        for (int x = 1; x <= 5; x++)
        { 
            Instantiate(obj_To_Spawn);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

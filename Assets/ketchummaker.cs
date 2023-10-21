using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ketchummaker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject object_clone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(object_clone);
            print(Random.Range(0,50));
        }
    }
}

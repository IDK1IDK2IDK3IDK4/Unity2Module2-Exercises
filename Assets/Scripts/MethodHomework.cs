using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodHomework : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(num());
        }
    }

    IEnumerator num()
    {
        yield return new WaitForSeconds(2);
        print(Random.Range(0, 10));
        yield return new WaitForSeconds(2);
        Time.timeScale = 2f;
    }
}

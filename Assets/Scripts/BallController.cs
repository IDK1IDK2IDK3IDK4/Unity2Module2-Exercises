using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallController : MonoBehaviour
{
    public TMP_Text updateText;
    public TMP_Text fixedUpdateText;
    public int update_counter;
    public int fixed_update_counter;
    //Declare and intialize updateCounter and fixedUpdateCounter here
    
    //Declare mr here
    

    // Start is called before the first frame update
    void Start()
    {
        //Set mr to get MeshRenderer component here
        
    }

    // Update is called once per frame
    void Update(){
        //disable MeshRenderer component below

        //increment updateCounter by 1 below
        update_counter += 1;
        
        //END OF CODE
        
        //Uncomment line below when update function is completed
        updateText.text = "Update Counter: " + update_counter.ToString();
        
    }
    
    //Create FixedUpdate function below
    void FixedUpdate()
    {
        //increment fixedUpdateCounter by 1 and update fixedUpdateText below
        fixed_update_counter += 1;
        fixedUpdateText.text = "Fixed Update Counter: " + fixed_update_counter.ToString();
        //END OF CODE
    }
}

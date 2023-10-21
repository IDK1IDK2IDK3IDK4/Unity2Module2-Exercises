using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeController : MonoBehaviour
{
    public TMP_Text scoreText;
    public int visible_number = 21;
    private int invisible_count = 0;
    private int current_number = 0;
    public int score = 0;
    public Vector3 position;
    //DECLARE VARIABLES HERE
    

    // Start is called before the first frame update
    void Start()
    {
        //INITIALIZE CURRENTNUM HERE
    }

    // Update is called once per frame
    void Update()
    {
        //INCREMENT AND PRINT CURRENTNUM HERE 

        //uncomment the code below and complete 
        //the if statement to check if mouse0 is clicked 
        if (Input.GetKeyDown(KeyCode.P))
        {
            score++;
            scoreText.text = "score: " + score.ToString();
        }
    }
    void FixedUpdate()
    {
        
    }
}

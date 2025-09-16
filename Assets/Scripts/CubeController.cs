using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeController : MonoBehaviour
{
    public TMP_Text scoreText;
    private int currentNum;
    public int score = 0;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        // EXERCISE 2-3: INITIALIZE CURRENTNUM HERE
    }

    // Update is called once per frame
    void Update()
    {
        // EXERCISE 2-3: INCREMENT AND PRINT CURRENTNUM HERE 

        // EXERCISE 2-3: Uncomment the code below and complete 
        // the if statement to check if Mouse0 is clicked 
        if (Input.GetMouseButtonDown(0))
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }
}

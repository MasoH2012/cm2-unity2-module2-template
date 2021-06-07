using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallController : MonoBehaviour
{
    //Declare and intialize updateCounter and fixedUpdateCounter here
    public float updateCounter = 0;
    public float fixedUpdateCounter = 0;
    public TMP_Text updateText;
    public TMP_Text fixedUpdateText;
    //Declare mr here
    private MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        //Set mr to get MeshRenderer component here
        mr = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update(){
        //disable MeshRenderer component below
        mr.enabled = false;
        //increment updateCounter by 1 below
        updateCounter += 1;
        //END OF CODE
        updateText.text = "Update Counter: " + updateCounter.ToString();
        
    }
    
    //Create FixedUpdate function below
    void FixedUpdate()
    {
        //increment fixedUpdateCounter by 1 and update fixedUpdateText below
        fixedUpdateCounter += 1;
        
        fixedUpdateText.text = "Fixed Update Counter: " + fixedUpdateCounter.ToString();
        //END OF CODE
    }
}

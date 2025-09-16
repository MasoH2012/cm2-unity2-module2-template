using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallController : MonoBehaviour
{
    public TMP_Text updateText;
    public TMP_Text fixedUpdateText;
    public float updateCounter;
    public float fixedUpdateCounter;
    private MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update(){
        mr.enabled = false;
        
        updateCounter++;
        
        updateText.text = "Update Counter: " + updateCounter.ToString();
    }
    
    void FixedUpdate () {
    fixedUpdateCounter++;
    fixedUpdateText.text = "Fixed Update Counter: " + fixedUpdateCounter.ToString();
    }
}

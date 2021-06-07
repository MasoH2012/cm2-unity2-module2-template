using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeController : MonoBehaviour
{
    private int currentNum;
    public int score = 0;
    public TMP_Text scoreText;
    public Vector3 position;
    private float xPos;
    private float yPos;
    private float zPos;

    // Start is called before the first frame update
    void Start()
    {
        currentNum = 0;
        transform.position = position;

    }

    // Update is called once per frame
    void Update()
    {
        currentNum += 1;
        print(currentNum);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }
}

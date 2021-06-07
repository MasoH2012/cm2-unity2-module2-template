using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingTarget : MonoBehaviour
{
    private float randX;
    private float randY;
    private float randZ;
    // Start is called before the first frame update
    void Start()
    {
        //WRITE CODE HERE
        randX = Random.Range(-24, 25);
        randY = Random.Range(0, 13);
        randZ = Random.Range(4, 14);
        //END OF CODE

        transform.position = new Vector3(randX, randY, randZ);

    }

}

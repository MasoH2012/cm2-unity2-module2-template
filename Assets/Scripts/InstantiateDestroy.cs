using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateDestroy : MonoBehaviour
{
    public GameObject prefab;
    public float delayDestroy = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clone = Instantiate(prefab);
            Destroy(clone, delayDestroy);
        }
    }
}

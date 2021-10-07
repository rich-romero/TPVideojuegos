using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    public float slicerSpeed;
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(slicerSpeed, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        slicerSpeed = -slicerSpeed;
    }
}

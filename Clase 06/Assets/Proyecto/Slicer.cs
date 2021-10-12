using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    public float slicerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(slicerSpeed*Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        slicerSpeed = -slicerSpeed;
    }
}

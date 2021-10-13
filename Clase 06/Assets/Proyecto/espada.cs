using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espada : MonoBehaviour
{
    public float speed;
    public float finslash;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("die", finslash);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed*Time.deltaTime, -speed*Time.deltaTime, 0);
        if (transform.rotation.x> finslash)
        {
            die();
        }
    }

    void die()
    {
        Destroy(this.gameObject);
    }
}

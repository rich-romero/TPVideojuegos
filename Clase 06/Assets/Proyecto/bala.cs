using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("die", 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);
    }

    void die()
    {
        Destroy(this.gameObject);
    }
}
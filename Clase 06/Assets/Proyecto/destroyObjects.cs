using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObjects : MonoBehaviour
{
    public float unspawn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("die", unspawn);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void die()
    {
        Destroy(this.gameObject);
    }
}

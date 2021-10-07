using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activacion : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("activar", 1);
    }

    void activar() 
    {
        target.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        activar();
    }

}

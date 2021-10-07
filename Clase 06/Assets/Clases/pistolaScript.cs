using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolaScript : MonoBehaviour
{
    public GameObject prefab;
    public float delay;
    public float frequency;
    public AudioSource disparoSonido;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Invoke("disparo", delay);
        };
        if (Input.GetButtonUp("Fire1"))
        {
            cancelDisparo();
        };



    }

    private void disparo() {
        Invoke("disparo", frequency);
        disparoSonido.Play();
        Instantiate(prefab,transform.position,transform.rotation);
        //Invoke("cancelDisparo", 5);
    }

    private void cancelDisparo()
    {
        CancelInvoke("disparo");
    }
    private void Awake()
    {
        //Invoke("disparo", delay);
    }

    

}

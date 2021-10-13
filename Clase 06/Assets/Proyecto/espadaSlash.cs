using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espadaSlash : MonoBehaviour
{
    public GameObject prefab;
    public float delay;
    public float frequency;
    public AudioSource slashSonido;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Invoke("slash", delay);
            Debug.Log("slash update");
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            cancelSlash();
        }



    }

    private void slash()
    {
        Debug.Log("slash metodo");
        Invoke("slash", frequency);
        Instantiate(slashSonido, transform.position, transform.rotation);
        slashSonido.Play();
        Instantiate(prefab, transform.position, Quaternion.Euler((float)-45, (float)45, (float)0));
        
        //Invoke("cancelDisparo", 5);
    }

    private void cancelSlash()
    {
        CancelInvoke("slash");
    }
}

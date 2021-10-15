using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploRay : MonoBehaviour
{
    public Renderer render;
    public LayerMask layers;
    public float length;
    public LayerMask obstacles;
    Transform target;

    public Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*bool ray = Physics.Raycast(transform.position, transform.forward, length, layers);
        if (ray)
        {
            render.material.color = Color.red;
        }
        else render.material.color = Color.green;
        Debug.DrawRay(transform.position, transform.forward * length); */

        RaycastHit hit;
        RaycastHit hit2;
        /*if( Physics.Raycast(transform.position, transform.forward, out hit, length, layers))
         {
             GameObject target = hit.transform.gameObject;



                 if(target.GetComponent<jugador>()!=null)
             {
                 target.GetComponent<jugador>().takeDmg2(1);
             }

         }     */

        /*if(Input.GetKeyDown(KeyCode.Space ))
         {
             Debug.Log("tecla");
            if( Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, length, layers))
                 {
                 Debug.Log("rayo1");
                 if (!Physics.Raycast(transform.position, transform.forward, out hit2, hit.distance, obstacles))
                 {
                     Debug.Log("rayo2");
                     if(true)
                     {
                         Destroy(hit.transform.gameObject);
                     }
                 }
                 else
                 {
                     Debug.Log("obstacle");
                 }

                  }
         }
        */
        Camera kamera = GetComponentInChildren<Camera>(); 

       if( Physics.Raycast(kamera.ScreenPointToRay(Input.mousePosition),out hit,layers))
        {
            GameObject cosa = hit.transform.gameObject;
            cosa.GetComponent<Renderer>().material.color=Color.blue;
        }
        //Debug.Log(Input.mousePosition.y);

       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clasepresencial051021 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // detecta elementos en esa esfera
        /*Collider[] Cols = Physics.OverlapSphere(transform.position, 10f);
        foreach(Collider Col in Cols)
        {
            Debug.Log(Col.name); 
        }*/

        // detecta elementos en esa esfera
        
        Collider[] Cols = Physics.OverlapSphere(transform.position, 10f/* , Integer de layer*/);
        Collider Closest=new Collider();
        float ClosestDist = float.MaxValue;
        foreach (Collider Col in Cols)
        {
            float dist;
            dist = Vector3.Distance(transform.position, Col.transform.position);
            if (ClosestDist > dist && ClosestDist>0)
            {
                ClosestDist = dist;
                Closest = Col;
            }
            Debug.Log(Col.name);
        }

        Debug.Log(Closest.name);

        /*public void takedmg(float dmg);*/
    }
}

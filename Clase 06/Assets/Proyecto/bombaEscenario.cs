using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaEscenario : MonoBehaviour,FakeTrigger
{
    public float timer;
    public float radius;
    public float OptimalRadius;
    public LayerMask layers;
    public int dmg;   
    public float force;
    /*    foreach (Collider Col in Cols)
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

        Debug.Log(Closest.name);*/
    // Start is called before the first frame update
    void Start()
    {
        Invoke("explode", timer);
    }

// Update is called once per frame
void Update()
{
        
}

    public void explode()
    {
        Collider[] Cols = Physics.OverlapSphere(transform.position, radius, layers);
        foreach (Collider Col in Cols)
        {
            if(Col.GetComponent<hiboxLink>()!=null)
            {
                float dist = Vector3.Distance(transform.position, Col.transform.position);
                if(dist<OptimalRadius)
                {
                    Col.GetComponent<hiboxLink>().FakeTriggerEnter(dmg, force, transform.position);
                }
                else
                {
                    Col.GetComponent<hiboxLink>().FakeTriggerEnter(Dmg(dist), push(dist), transform.position);
                }

            }
            
        }
        
    }

    public float push(float dist)
    {
        float multiplier = OptimalRadius / dist;
        return force*multiplier;
    }

    public int Dmg(float dist)
    {
        float multiplier = OptimalRadius / dist;

        return (int)((float)dmg*multiplier);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase10Bomba2 : MonoBehaviour
{
    public float timer;
    public float maxDmg;
    public float explosionRadius;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Explode()
    {/*
        Collider[] Cols = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider Col in Cols)
        {
            if (Col.GetComponent<Character>() != null)
            {
                float Dist = Vector3.Distance(transform.position, Col.transform.position);
                float DmgRadius = Dist / explosionRadius;
                DmgRadius = 1 - DmgRadius;
                float Dmg = maxDmg * DmgRadius;
                if (Dmg > maxDmg) Dmg = maxDmg;
                Col.GetComponent<Character>().GetDmg(Dmg);
            }
        }
        Destroy(gameObject);*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}

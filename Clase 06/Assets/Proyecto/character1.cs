using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character1 : MonoBehaviour, Damageable, Pushable
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*public virtual void takeDamage(Vector3 golpe, float dmg)
    {
        // ARREGLAR charact.takeDamage(float dmg);
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDmg(int dmg)
    {
        takeDmg2(dmg);
        Debug.Log("Recibió Daño");
    }
    public virtual void takeDmg2(int dmg)
    {

    }

    public void bePushed(float force, Vector3 position)
    {
        bePushed2(force, position);
        Debug.Log("fué empujado");
    }

    public virtual void bePushed2(float force, Vector3 position)
    {

    }
}

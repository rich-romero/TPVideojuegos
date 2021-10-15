using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiboxLink : MonoBehaviour
{
    public character1 charr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FakeTriggerEnter(int dmg, float force, Vector3 position)
    {
        
        
            charr.bePushed(force, position);
            charr.takeDmg(dmg,false);
        
    }
    private void OnTriggerEnter(Collider other)
    {    
        if (other.GetComponent<Hurtbox>() != null)
        {
            Hurtbox hurtbox = other.GetComponent<Hurtbox>();
            charr.bePushed(hurtbox.push, other.transform.position);
            charr.takeDmg(hurtbox.Dmg, hurtbox.rupiadrop);
            if (hurtbox.rupiadrop)
            {
                hurtbox.rupiaEnd();
                //TERMINAR RUPIA END PARA EL 19/10
            }
        }
        Debug.Log("COlisinó");
        //other.transform
    }
}

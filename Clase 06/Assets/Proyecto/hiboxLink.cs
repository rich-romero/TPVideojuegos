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
            charr.takeDmg(dmg);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Hurtbox>() != null)
        {
            charr.bePushed(other.GetComponent<Hurtbox>().push, other.transform.position);
            charr.takeDmg(other.GetComponent<Hurtbox>().Dmg);
        }
        Debug.Log("COlisin�");
        //other.transform
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiboxLink : MonoBehaviour
{
    public character1 link;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        link.takeDamage(other.transform.position, GetComponent<enemy>().dmg());
        Debug.Log("COlisinó");
        //other.transform
    }
}

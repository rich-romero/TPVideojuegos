using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.UI;

public class C09Text : MonoBehaviour
{
    public Text Titulo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey("Submit");
        if (Input.GetKey(KeyCode.A))
        {
            Titulo.text = "apretaste a";
        }
        if (Input.GetKey(KeyCode.B))
        {
            Titulo.text = "apretaste b";
        }
            
            
            ;
    }
}

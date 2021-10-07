using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C0902BalasDisponibles : MonoBehaviour
{
    public Text BalasText;
    private string bullets = "bullets: ";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey("Submit");
        if (Input.GetKey(KeyCode.Space))
        {
            //Titulo.text = "apretaste a";
        }
        if (Input.GetKey(KeyCode.B))
        {
            //Titulo.text = "apretaste b";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadMov;
    public float velocidadRot;
    public float vida;
    public Rigidbody rb;
    public bool cubeIsOnTheGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //MOVIMIENTO WS
        transform.Translate(
            new Vector3(
                0,
                0, 
                Input.GetAxis("Vertical") * velocidadMov
                )
            );
        ;
        //ROTACION AD
        transform.Rotate(
                0,
                Input.GetAxis("Horizontal") * velocidadRot,
                0
            );

        if (Input.GetButtonUp("Jump"))
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            cubeIsOnTheGround = false;
        };
        //PRUEBA DAÑO
        if (Input.GetKey(KeyCode.U))
        {
            vida--;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            cubeIsOnTheGround = true;
        }
    }
}

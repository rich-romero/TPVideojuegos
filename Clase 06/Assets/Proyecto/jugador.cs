using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour, Damageable, Pushable

{
    public float velocidadMov;
    public float velocidadRot;
    public float vida;
    public Rigidbody rb;
    public bool cubeIsOnTheGround;
    public float salto;
    public int impacto;

    public Renderer body;
    public Renderer head;
    private Color colHead;
    private Color colBody;

    public float damageBoostTime;
    private int damageBoostCycles = 5;
    private bool damageFlag = true;
    private bool stunFlag =true;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        colHead = head.material.color;
        colBody = body.material.color;

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

        if (Input.GetButton("Jump")&& cubeIsOnTheGround==true)
        {
            rb.AddForce(new Vector3(0, salto, 0), ForceMode.Impulse);
            cubeIsOnTheGround = false;
        };
        //PRUEBA DAÑO
        if (Input.GetKey(KeyCode.U))
        {
            vida--;
        }

    }

    public void visualQueue()
    {
        damageBoost();
    }
    public void takeDamage(Vector3 golpe, float dmg) {
        if (damageFlag)
        {
            damageFlag = false;
            vida -= dmg;
            rb.AddForce(Vector3.Normalize(transform.position - golpe)*impacto, ForceMode.Impulse);
            visualQueue();
        }
    }

    private void knockback()
    {
        stunFlag = false;
        rb.AddForce(new Vector3(0, salto, 0), ForceMode.Impulse);
    }
    private void endKnockback()
    {
        stunFlag = true;
    }

    public void damageBoost()
    {
        Invoke("endDamageBoost", (float)0.3);
        head.material.color =Color.red;
        body.material.color = Color.red;
    }
    public void endDamageBoost()
    {
        Debug.Log(damageBoostCycles);
        head.material.color = colHead;
        body.material.color = colBody;
        if (damageBoostCycles>0)
        {
            Invoke("damageBoost", (float)0.3);
            damageBoostCycles -= 1;
        }
        else
        {
            damageBoostCycles = 5;
            damageFlag = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "floor")
        {
            cubeIsOnTheGround = true;
        }

    }

    public void takeDmg(int dmg)
    {
        if (damageFlag)
        {
            damageFlag = false;
            vida -= dmg;
            visualQueue();
        }
    }

    public void bePushed(float force, Vector3 position)
    {
        if(damageFlag)
        rb.AddForce(Vector3.Normalize(transform.position - position) * force, ForceMode.Impulse);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : character1
{
    public List<Transform> RallyPoints;
    private int Current = 0;
    [SerializeField]
    private float skeletonSpeed = (float)0.1;
    public GameObject player;
    public int vida;
    public float PlayerDist;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    public float dmg()
    {
        return 1;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(slicerSpeed, 0, 0);
        if (Vector3.Distance(player.transform.position, transform.position) < PlayerDist)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, skeletonSpeed*Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, RallyPoints[Current].position, skeletonSpeed*Time.deltaTime);
            if (Vector3.Distance(transform.position, RallyPoints[Current].position) < skeletonSpeed*Time.deltaTime)
            {
                Current++;
                Current = Current % RallyPoints.Count;
            }
        }






    }
    private void OnCollisionEnter(Collision collision)
    {
        //skeletonSpeed = -skeletonSpeed;
    }
    public override void bePushed2(float force, Vector3 position)
    {
        rb.AddForce(Vector3.Normalize(transform.position - position) * force, ForceMode.Impulse);
    }
    public override void takeDmg2(int dmg)
    {
        Debug.Log("skeleto recibio daño");
    }
    private void redirect()
    {
        ///object p = Random(4);
        //let directions =[90, 180, 270, 0];
        //transform.rotation()
    }

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour, enemy
{
    public List<Transform> RallyPoints;
    private int Current = 0;
    private float skeletonSpeed = (float)0.1;
    public GameObject player;
    public int vida;
    // Start is called before the first frame update
    void Start()
    {

    }

    float dmg()
    {
        return 1;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(slicerSpeed, 0, 0);
        if (Vector3.Distance(player.transform.position, transform.position) < (float) 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, skeletonSpeed);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, RallyPoints[Current].position, skeletonSpeed);
            if (Vector3.Distance(transform.position, RallyPoints[Current].position) < skeletonSpeed)
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
    private void redirect()
    {
        ///object p = Random(4);
        //let directions =[90, 180, 270, 0];
        //transform.rotation()
    }

}



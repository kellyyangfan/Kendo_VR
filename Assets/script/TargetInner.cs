using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetInner : MonoBehaviour
{
    public Transform LeftTop;
    public Transform LeftBottom;
    public Transform RightTop;
    public Transform RightBottom;

    //public GameObject LeftTop;
    //public GameObject LeftBottom;
    //public GameObject RightTop;
    //public GameObject RightBottom;

    public GameObject Target;

    private Transform[] TargetQueue;
    private int TargetNum;



    // Start is called before the first frame update
    void Start()
    {
        TargetQueue = new Transform[] { LeftTop, LeftBottom, RightTop, RightBottom };
        //TargetQueue = new GameObject[] { LeftTop, LeftBottom, RightTop, RightBottom };

        TargetNum = TargetQueue.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision c)
    {
        Debug.Log("Collide");
        if (c.gameObject.tag == "SwordTip")
        {
            //transform.position = TargetQueue
            Debug.Log(TargetQueue[Random.Range(0, 4)].position);

            //Target.transform.position = TargetQueue[0].position;
            //Target.transform.rotation = TargetQueue[0].rotation;

            Target.transform.position = TargetQueue[Random.Range(0, 4)].position;
            Target.transform.rotation = TargetQueue[Random.Range(0, 4)].rotation;


        }
    }
}

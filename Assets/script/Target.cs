using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //public Transform LeftTop;
    //public Transform LeftBottom;
    //public Transform RightTop;
    //public Transform RightBottom;

    //private Transform[] TargetQueue;
    //private int TargetNum;

    private GameObject Outer;
    private GameObject Inner;

    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Outer = transform.Find("Outer").gameObject;
        Inner = transform.Find("Inner").gameObject;

        //TargetQueue = new Transform[] { LeftTop , LeftBottom , RightTop , RightBottom };
        //TargetNum = TargetQueue.Length;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float OuterScale = 0.01f + Mathf.Sin(time)*0.3f;
        Outer.transform.localScale = new Vector3(OuterScale, 0.01f, OuterScale);

    }

    //void OnCollisionEnter(Collision c) { 
    //    if(c.gameObject.tag == "SwordTip") {
    //        //transform.position = TargetQueue
    //        Debug.Log(TargetQueue[Random.Range(0,4)].position);
    //    }
    //}
}

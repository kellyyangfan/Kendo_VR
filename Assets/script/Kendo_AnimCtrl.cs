using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kendo_AnimCtrl : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1")) {
            Debug.Log("1");
            animator.SetTrigger("Pos1");

        }

        if (Input.GetKey("2"))
        {
            //animator.SetBool("Pos2", true);
            animator.SetTrigger("Pos2");
        }

        if (Input.GetKey("3"))
        {
            animator.SetTrigger("Pos3");

        }
        //prevent rotation

    }
}

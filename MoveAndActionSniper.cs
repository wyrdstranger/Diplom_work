using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveAndActionSniper : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;
    Animator animator;
    private bool IfSniperWalking;
    private NavMeshAgent myAgent;
    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            myAgent.isStopped = false;
            IfSniperWalking = true;
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo, 100, whatCanBeClickedOn))
            {
                myAgent.SetDestination(hitInfo.point);
            }

            animator.SetBool("isWalking", true);
        }
        else if (myAgent.remainingDistance == 0)
        {
            IfSniperWalking = false;
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.F) && (IfSniperWalking==false))
        {
            animator.SetBool("isWalking", false);
            //animator.SetBool("isShooting", true);
        }
        else
        {
            //animator.SetBool("isShooting", false);
        }

        if (Input.GetKeyDown(KeyCode.C) && (IfSniperWalking == false))
        {
            //Debug.Log("C is pressed");
            animator.SetBool("isWalking", false);
            animator.SetBool("isDoing", true);
        }
        else
        {
            animator.SetBool("isDoing", false);
        }
    }
}

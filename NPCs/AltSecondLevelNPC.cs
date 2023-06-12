using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AltSecondLevelNPC : MonoBehaviour
{
    public Transform CharacterToFollow;
    public float AllowedDistance = 5;
    Animator animator;

    private NavMeshAgent myAgent;
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAgent.SetDestination(CharacterToFollow.position);
        if (myAgent.remainingDistance <= AllowedDistance)
        {
            myAgent.isStopped = true;
            print("Distance is:");
            print(myAgent.remainingDistance);
            animator.SetBool("isWalking", false);
        }
        else
        {
            animator.SetBool("isWalking", true);
            myAgent.isStopped = false;
        }
    }
}

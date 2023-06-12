using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StopMove : MonoBehaviour
{
    private NavMeshAgent myAgent;
    Animator animator;
    [SerializeField] private GameObject CanvasGameOver;
    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isWalking", false);
        myAgent.isStopped = true;


        if (CanvasGameOver.activeInHierarchy)
        {
            animator.SetBool("isDead", true);
        }
    }
}

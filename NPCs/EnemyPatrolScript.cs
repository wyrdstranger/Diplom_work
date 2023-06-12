using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrolScript : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;
    public float timer;

    private int waypointIndex;
    private float distance;
    private NavMeshAgent myAgent;
    float timeCount;

    Animator animator;

    void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
        myAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

    }


    void Update()
    {
        //distance = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        //if (distance < 1f)
        //{
        //    animator.SetBool("isWalking", false);
        //    IncreaseIndex();

            //}
        if (myAgent.remainingDistance == 0)
        {
            animator.SetBool("isWalking", false);
            IncreaseIndex();
        }

        Patrol();
    }
    
    void Patrol()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        myAgent.SetDestination(waypoints[waypointIndex].position);
        animator.SetBool("isWalking", true);
    }

    void IncreaseIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        //transform.LookAt(waypoints[waypointIndex].position);

    }
}

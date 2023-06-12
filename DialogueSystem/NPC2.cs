using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC2 : MonoBehaviour
{
    //quest
    public GameObject quest;
    public GameObject dialogueCanvas;
    private bool dialogueSuccess;
    //move
    private NavMeshAgent myAgent;
    public Transform CharacterToFollow;
    public float AllowedDistance = 2;
    private bool followCharacter;
    //other
    Animator animator;
    bool isHealed;
    // Start is called before the first frame update
    private void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        isHealed = false;
        animator = GetComponent<Animator>();
        dialogueSuccess = false;
        followCharacter = false;
    }
    public void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.name == "Medic") && Input.GetKeyDown(KeyCode.C))
        {
            isHealed = true;
            animator.SetBool("isHealed", true);
        }
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.F) && (isHealed == true))
        {
            if (dialogueSuccess == false)
            {
                dialogueCanvas.SetActive(true);
                quest.SetActive(true);
                dialogueSuccess = true;
            }
            else if (dialogueSuccess == true)
            {
                dialogueCanvas.SetActive(false);
                quest.SetActive(false);
            }
            followCharacter = true;
        }

        if (followCharacter==true)
        {
            //moving
            myAgent.SetDestination(CharacterToFollow.position);
            if (myAgent.remainingDistance <= AllowedDistance)
            {
                myAgent.isStopped = true;
                //print("Distance is:");
                //print(myAgent.remainingDistance);
                animator.SetBool("isWalking", false);
            }
            else
            {
                animator.SetBool("isWalking", true);
                myAgent.isStopped = false;
            }
        }

    }
}

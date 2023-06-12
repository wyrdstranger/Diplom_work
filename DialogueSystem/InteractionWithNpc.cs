using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithNpc : MonoBehaviour
{
    public GameObject quest;
    public GameObject dialogueCanvas;
    private bool dialogueSuccess;
    Animator animator;
    bool isHealed;
    // Start is called before the first frame update
    private void Start()
    {
        isHealed = false;
        animator = GetComponent<Animator>();
        dialogueSuccess = false;
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

        }

    }
}

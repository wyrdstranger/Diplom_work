using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToSecondLevel : MonoBehaviour
{
    public GameObject other;

    public void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("SecondLevel");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGameWin : MonoBehaviour
{
    [SerializeField] private GameObject CanvasGameWin;
    
    public void OnTriggerStay(Collider character)
    {
        if ((character.gameObject.tag == "NPC") && (Input.GetKeyDown(KeyCode.F)))
        {

            print("Game is over!");
            CanvasGameWin.SetActive(true);
        }
    }
}

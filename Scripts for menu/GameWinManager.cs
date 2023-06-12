using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinManager : MonoBehaviour
{
    [SerializeField] private GameObject CanvasGameWin;

    public void OnTriggerStay(Collider character)
    {
        if ((character.gameObject.tag == "Player") && (Input.GetKeyDown(KeyCode.F)))
        {

            print("Game is over!");
            CanvasGameWin.SetActive(true);
        }
    }
}

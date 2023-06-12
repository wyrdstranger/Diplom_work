using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAura : MonoBehaviour
{
    Animator animator;
    //public GameObject aura;
    [SerializeField] private GameObject CanvasGameOver;

    void Start()
    {
        
    }


    void Update()
    {

    }

    public void OnTriggerStay(Collider character)
    {
        if (character.gameObject.tag == "Player")
        {
            print("Game is over!");
            CanvasGameOver.SetActive(true);
        }
    }
}

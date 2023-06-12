using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinesScript : MonoBehaviour
{
    [SerializeField] private GameObject mine;
    [SerializeField] private GameObject CanvasGameOver;
    [SerializeField] private GameObject explosionEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider character)
    {
        if ((character.gameObject.tag == "Player") && (character.gameObject.name != "Sapper"))
        {
            explosionEffect.SetActive(true);
            print("Game is over!");
            CanvasGameOver.SetActive(true);
        }
        if ((character.gameObject.name == "Sapper") && (Input.GetKeyDown(KeyCode.C)))
        {
            Destroy(mine);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTitle : MonoBehaviour
{
    [SerializeField] private GameObject CanvasTitle;
    [SerializeField] private Transform character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (character.GetComponent<MoveAndActionSniper>().enabled == true)
        {
            CanvasTitle.SetActive(true);
        }
        else
        {
            CanvasTitle.SetActive(false);
        }
    }
}

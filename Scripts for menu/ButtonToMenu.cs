using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToMenu : MonoBehaviour
{
    [SerializeField] private GameObject CanvasA;
    private int simpleCounter;
    // Start is called before the first frame update
    void Start()
    {
        simpleCounter = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape is pressed, counter:" + simpleCounter);
            if (simpleCounter >= 1)
            {
                enableCanvas();
                simpleCounter = 0;
            }
            else
            {
                disableCanvas();
                simpleCounter++;
            }

            
        }
    }

    void disableCanvas()
    {
        CanvasA.SetActive(false);
    }

    void enableCanvas()
    {
        CanvasA.SetActive(true);
    }
}

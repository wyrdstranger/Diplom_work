using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject CanvasGameOver;
    [SerializeField] private GameObject CanvasGameMenu;
    [SerializeField] private GameObject CanvasDialogue;
    [SerializeField] private GameObject CanvasGameWin;
    public CharacterSwap currentCharacter;
    public Transform gameCamera;
    public Transform gameManager;
    public List<Transform> possibleCharacters;
    public int choosenCharacter;
    public Transform character;
    // Start is called before the first frame update
    void Start()
    {
        CanvasGameMenu.SetActive(false);
        CanvasGameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((CanvasGameOver.activeInHierarchy) || (CanvasGameMenu.activeInHierarchy) || (CanvasDialogue.activeInHierarchy) || (CanvasGameWin.activeInHierarchy))
        {
           for (int i = 0; i < possibleCharacters.Count; i++)
            {
                possibleCharacters[i].GetComponent<MoveAndActionSniper>().enabled = false;
                possibleCharacters[i].GetComponent<StopMove>().enabled = true;
            }
            gameCamera.GetComponent<CameraMovement>().enabled = false;
            gameManager.GetComponent<CharacterSwap>().enabled = false;
        }

        if ((!CanvasGameOver.activeInHierarchy) && (!CanvasGameMenu.activeInHierarchy) && (!CanvasDialogue.activeInHierarchy) && (!CanvasGameWin.activeInHierarchy))
        {
            choosenCharacter = currentCharacter.choosenCharacter;
            gameCamera.GetComponent<CameraMovement>().enabled = true;
            gameManager.GetComponent<CharacterSwap>().enabled = true;
            character = possibleCharacters[choosenCharacter];
            character.GetComponent<MoveAndActionSniper>().enabled = true;
            character.GetComponent<StopMove>().enabled = false;
            for (int i = 0; i < possibleCharacters.Count; i++)
            {
                if (possibleCharacters[i]!= character)
                {
                    possibleCharacters[i].GetComponent<MoveAndActionSniper>().enabled = false;
                    possibleCharacters[i].GetComponent<StopMove>().enabled = true;
                }
            }
        }
    }
}

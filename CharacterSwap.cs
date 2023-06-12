using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterSwap : MonoBehaviour
{
    public Transform character;
    public List<Transform> possibleCharacters;
    public int choosenCharacter;

    // Start is called before the first frame update
    void Start()
    {
        if (character == null && possibleCharacters.Count >= 1)
        {
            character = possibleCharacters[0];
        }
        Swap();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (choosenCharacter == 0)
            {
                choosenCharacter = possibleCharacters.Count - 1;
            }
            else
            {
                choosenCharacter -= 1;
            }
            Swap();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (choosenCharacter == possibleCharacters.Count - 1)
            {
                choosenCharacter = 0;
            }
            else
            {
                choosenCharacter += 1;
            }
            Swap();
        }
    }

    public void Swap()
    {
        character = possibleCharacters[choosenCharacter];
        character.GetComponent<MoveAndActionSniper>().enabled = true;
        character.GetComponent<StopMove>().enabled = false;
        for (int i = 0; i < possibleCharacters.Count; i++)
        {
            if (possibleCharacters[i] != character)
            {
                possibleCharacters[i].GetComponent<MoveAndActionSniper>().enabled = false;
                possibleCharacters[i].GetComponent<StopMove>().enabled = true;
            }
        }
    }
}

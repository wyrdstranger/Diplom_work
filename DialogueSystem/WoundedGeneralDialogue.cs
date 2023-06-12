using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;

public class WoundedGeneralDialogue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<ManagerForDialogue>().StartDialogue(Conversation());
    }

    private DialogueSection Conversation()
    {
        string localName = "Pаненый командир";

        Monologue info = new Monologue(localName, "они пытались узнать план нашей контратаки, но я им нераскрыл этого. Теперь нам надо бежать");
        Monologue walkwith = new Monologue(localName, "я смогу и действительно, надо бежать пока они не обнаружили мою пропажу");
        Choices b = new Choices(localName, "аргх, спасибо, я уж думал что полягу здесь", ChoiceList(Choice("что они пытались узнать?", info), Choice("вы сможете идти за мной?", walkwith)));


        return b;
    }
}

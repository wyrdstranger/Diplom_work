using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;

public class GeneralLesson : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<ManagerForDialogue>().StartDialogue(Conversation());
    }

    private DialogueSection Conversation()
    {
        string localName = "Генерал";

        Monologue fine = new Monologue(localName, "Приятно слышать, только запомни - пройти миссию можно только выполнив все задачи. А теперь бегом!");
        Monologue not_fine = new Monologue(localName, "Тогда бегом чистить картошку!");

        Choices b = new Choices(localName, "Для этого тебе надо дойти до красного круга и нажать F. Ясно?", ChoiceList(Choice("Да, товарищ командир!", fine)));
        Monologue a = new Monologue(localName, "Молодец, ты прошёл обучение. Следующая твоя цель - успешно покинуть миссию. ", b);

        return a;
    }
}

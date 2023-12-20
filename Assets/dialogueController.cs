using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogueController : MonoBehaviour
{
    public TextMeshProUGUI DialogueText; // Fixed typo in TextMeshProUGUI
    public string[] sentences; // Fixed typo in "sentences"
    private int index = 0;
    public float DialogueSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Fixed typo in "Space"
        {
            NextLine();
        }
    }

    void NextLine()
    {
        if (index <= sentences.Length - 1) // Fixed typo in "Length"
        {
            DialogueText.text = ""; // Fixed typo in "text"
            StartCoroutine(WriteSent());
        }
    }

    IEnumerator WriteSent()
    {
        foreach (char Character in sentences[index].ToCharArray()) // Fixed typo in "ToCharArray"
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        index++;
    }
}

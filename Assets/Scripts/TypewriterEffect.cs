using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterEffect : MonoBehaviour
{
    public float typingSpeed = 0.1f; // Adjust the typing speed as needed
    private Text textComponent;
    private string fullText;

    void Start()
    {
        textComponent = GetComponent<Text>();
        fullText = textComponent.text;
        textComponent.text = ""; // Clear the initial text
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char c in fullText)
        {
            textComponent.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}

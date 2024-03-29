using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypingText : MonoBehaviour
{
    public Text TextGameObject;
    private string text;

    private void Start()
    {
        text = TextGameObject.text;
        TextGameObject.text = "";
        StartCoroutine(TextCoroutine());
    }
    IEnumerator TextCoroutine()
    {
        foreach (char abc in text)
        {
            TextGameObject.text += abc;
            yield return new WaitForSeconds(0.05f);
        }
    }
}

using TMPro;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public TMP_InputField inputField;
    private TouchScreenKeyboard keyboard;

    public void OpenKeyboard(string _)
    {
        if (TouchScreenKeyboard.isSupported)
        {
            keyboard = TouchScreenKeyboard.Open(inputField.text, TouchScreenKeyboardType.Default);
        }
    }

    void Update()
    {
        if (keyboard != null && keyboard.status == TouchScreenKeyboard.Status.Done)
        {
            inputField.text = keyboard.text;
        }
    }
}

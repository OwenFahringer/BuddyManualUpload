using UnityEngine;
using TMPro;
public class InputFieldGrabber : MonoBehaviour
{

    [SerializeField] private string inputText;

    [SerializeField] private GameObject reactionGroup;
    [SerializeField] private TMP_Text reactionTextBox;
   public void GrabFronInputField(string input)
    {
        inputText = input;
        DisplayReactionToInput();
    }

    private void DisplayReactionToInput()
    {
        reactionTextBox.text = "Create room";
        reactionGroup.SetActive(true);
    }
}
    
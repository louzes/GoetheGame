using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button firstButton;
    [SerializeField] private Button secondButton;
    [SerializeField] private Button thirdButton;

    private bool isSecondButtonActive;
    private bool isThirdButtonActive;

    private void Start()
    {
        firstButton.onClick.AddListener(ToggleSecondButton);
    }

    private void ToggleSecondButton()
    {
        isSecondButtonActive = !isSecondButtonActive;
        isThirdButtonActive = !isThirdButtonActive;
        secondButton.gameObject.SetActive(isSecondButtonActive);
        thirdButton.gameObject.SetActive(isThirdButtonActive);
    }
}

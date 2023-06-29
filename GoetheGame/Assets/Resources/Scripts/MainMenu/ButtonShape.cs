using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ButtonShape : MonoBehaviour
{
    [Range(0f, 1f)]
    [SerializeField] private float _level = 1f;
    [HideInInspector] private Image _imageButton;

    private void Start()
    {
        _imageButton = gameObject.GetComponent<Image>();
        _imageButton.alphaHitTestMinimumThreshold = _level;
    }
}

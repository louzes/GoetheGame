using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonsLogic : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] public AudioClip Click;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = Click;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = Vector3.one;
    }

    public void AudioClick()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(Click);
        }
    }
}

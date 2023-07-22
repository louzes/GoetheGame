using UnityEngine;

public class AnswerLogic : MonoBehaviour
{
    private GameObject answer;
    [SerializeField] private GameObject _sceneOne;
    [SerializeField] private GameObject _sceneTwo;
    [SerializeField] private GameObject _sceneThree;
    private Color red;
    [HideInInspector] public bool _turnedOn = false;
    [HideInInspector] public bool _turnedOnTwo = false;
    [HideInInspector] public bool _turnedOnThree = false;

    private void Start()
    {
        answer = FindObjectOfType<Activator>().gameObject;
    }

    public void OnRightCLick()
    {
        if (answer.CompareTag("Correct") || _sceneOne)
        {
            _turnedOn = true;
            TurnedOn(1);
        }
        if (answer.CompareTag("Correct") || _sceneTwo)
        {
            _turnedOnTwo = true;
            TurnedOn(2);
        }
        if (answer.CompareTag("Correct") || _sceneThree)
        {
            _turnedOnThree = true;
            TurnedOn(3);
        }

    }
    private void TurnedOn(int ID)
    {
        if (ID == 1)
        {
            //load
        }
        if (ID == 2)
        {
            //load
        }
        if (ID == 3)
        {
            //load
        }
    }
}

using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField] public GameObject SceneActive;
    [SerializeField] public GameObject SceneInactive;

    public void Active()
    {
        SceneActive.SetActive(true);
    }
    public void Inactive()
    {
        Debug.Log(1);
        SceneInactive.SetActive(false);
    }
}

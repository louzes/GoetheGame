using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public static NextLevel InstanceLevel;
    private void Start() => InstanceLevel = this;

    public void Mode61()
    {
        SceneManager.LoadScene(1);
    }
    public void Mode2()
    {
        SceneManager.LoadScene(2);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}

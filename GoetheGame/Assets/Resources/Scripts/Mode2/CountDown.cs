using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text one;
    public Text two;
    public Text three;

    public float delay;
    public GameObject bg;
    public GameObject theGame;

    private void Start()
    {
        one.gameObject.SetActive(true);
        bg.SetActive(true);
        theGame.SetActive(false);
        StartCoroutine(Delay());
    }
    IEnumerator Delay()
    {
        if (one.gameObject.activeSelf)
        {
            yield return new WaitForSeconds(delay);
            one.gameObject.SetActive(false);
            two.gameObject.SetActive(true);
        }
        if (two.gameObject.activeSelf)
        {
            yield return new WaitForSeconds(delay);
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(true);
        }
        if (three.gameObject.activeSelf)
        {
            yield return new WaitForSeconds(delay);
            three.gameObject.SetActive(false);
            bg.SetActive(false);
            theGame.SetActive(true);
        }
    }
}


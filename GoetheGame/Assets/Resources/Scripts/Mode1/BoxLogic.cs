using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxLogic : MonoBehaviour
{
    private bool isBeingAttracted = false;
    [SerializeField] private bool isRightBox;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cell" && !isBeingAttracted)
        {
            StartCoroutine(AttachCoroutine(collision.transform));
        }
    }

    private IEnumerator AttachCoroutine(Transform target)
    {
        isBeingAttracted = true;
        transform.position = target.position;

        yield return new WaitForSeconds(0.15f);

        isBeingAttracted = false;

        if (isRightBox)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cell")
        {
            isBeingAttracted = false;
        }
    }
}

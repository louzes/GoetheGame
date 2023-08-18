using System.Collections;
using UnityEngine;

public class BoxLogic : MonoBehaviour
{
    private bool isBeingAttracted = false;

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
        Debug.Log("ENTER");

        yield return new WaitForSeconds(0.1f);

        isBeingAttracted = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cell")
        {
            isBeingAttracted = false;
        }
    }
}

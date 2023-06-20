using UnityEngine;

public class BoxLogic : MonoBehaviour
{ 
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Correct")
        {
            transform.position = collision.transform.position;
            Debug.Log("ENTER");
        }
    }
}

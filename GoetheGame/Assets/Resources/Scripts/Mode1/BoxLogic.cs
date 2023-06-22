using UnityEngine;

public class BoxLogic : MonoBehaviour
{
    private void Start()
    {
        //GameObject[] cell = GameObject.FindGameObjectsWithTag("Cell");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cell")
        {
            transform.position = collision.transform.position;
            Debug.Log("ENTER");
        }
    }
    private void ObjectExit()
    {
      
    }
}

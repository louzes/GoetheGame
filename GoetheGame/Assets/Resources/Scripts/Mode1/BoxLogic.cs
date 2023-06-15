using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLogic : MonoBehaviour
{
    [SerializeField] public Transform CorrectBox;

    [SerializeField] private float _minDistance;
    [SerializeField] private float _speed;

    [HideInInspector] private bool _vstavka;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Correct")
        {
            _vstavka = true;
            Debug.Log("ENTER");
        }
        else _vstavka = false;
    }
    private void FixedUpdate()
    {
        if (_vstavka == true)
        {
            if (Vector2.Distance(transform.position, CorrectBox.position) > _minDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, CorrectBox.position, _speed * Time.deltaTime);
            }
        }
    }
}

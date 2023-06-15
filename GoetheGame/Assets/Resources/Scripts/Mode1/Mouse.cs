using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float clampAngle = 80f;

    private GameObject cursor;

    private float rotY = 0f;
    private float rotX = 0f;

    void Start()
    {
        Cursor.visible = false;

        cursor = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        cursor.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        cursor.GetComponent<Collider>().enabled = false;
        cursor.GetComponent<Renderer>().material.color = Color.red;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotY += mouseX;
        rotX -= mouseY;
        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        transform.rotation = Quaternion.Euler(rotX, rotY, 0f);

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        cursor.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0f);
    }
}


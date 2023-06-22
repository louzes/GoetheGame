using UnityEngine;

public class DragObject : MonoBehaviour
{
    [HideInInspector] private Vector3 _dragOff;
    [HideInInspector] private float _dragSpeed = 15f;

    private void OnMouseDown()
    {
        _dragOff = this.transform.position - GetMousePosition();
    }
    private void OnMouseDrag()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, GetMousePosition() + _dragOff, _dragSpeed * Time.deltaTime);
    }
    private Vector3 GetMousePosition()
    {
        var _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _mousePosition.z = 0;
        return _mousePosition;
    }
}

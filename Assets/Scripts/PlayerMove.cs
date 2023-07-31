using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed = 5;
    private float _oldMousePositionX;
    private float _eulerY;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _oldMousePositionX = Input.mousePosition.x;
            _animator.SetBool("Run", true);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition= transform.position + transform.forward * _speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
            transform.position = newPosition;
            float deltaX = Input.mousePosition.x - _oldMousePositionX;
            _oldMousePositionX = Input.mousePosition.x;
            _eulerY += deltaX;
            transform.eulerAngles = new Vector3(0, _eulerY, 0);
            _eulerY = Mathf.Clamp(_eulerY, -70, 70);
        }
        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool("Run", false);
        }
    }
}

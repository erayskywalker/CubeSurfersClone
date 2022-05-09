using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _leanSpeed = 0.05f, _forwardSpeed = 5f;
    Vector3 _firstPos, _endPos;

    private void Update()
    {
        GetPlayerInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void GetPlayerInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _firstPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            _endPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            _firstPos = Vector3.zero;
            _endPos = Vector3.zero;
        }
    }

    private void MovePlayer()
    {
        float x = _endPos.x - _firstPos.x;
        transform.Translate(x * Time.deltaTime * _leanSpeed, 0f, _forwardSpeed * Time.deltaTime);
    }
}

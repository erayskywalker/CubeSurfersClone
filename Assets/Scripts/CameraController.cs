using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] Transform _player;
    [SerializeField] float speed = 10f;

    private void Update()
    {

    }


    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(transform.position, _player.position + offset, speed);

    }
}
